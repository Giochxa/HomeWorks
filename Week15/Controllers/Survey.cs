using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Week15.Model;

namespace MyCoreApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonsController : ControllerBase
    {
        private const string JsonFilePath = "persons.json";

        [HttpPost("AddPerson")]
        public async Task<IActionResult> AddPerson([FromBody] AddPerson person)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid data. Please check the input.");
                }

                var validator = new PersonVvalidator();
                var result = validator.Validate(person);
                var errormassage = "";
                if (!result.IsValid)
                {
                    foreach (var item in result.Errors)
                    {
                        errormassage += item.ErrorMessage;
                    }
                    return BadRequest(errormassage);
                }
                // Read existing data from the JSON file
                var existingPersons = await ReadPersonsFromFile();

                // Add the new person to the list
                existingPersons.Add(person);

                // Write updated data back to the JSON file
                await WritePersonsToFile(existingPersons);

                return Ok(existingPersons);
                //return Ok("AddPerson data added successfully!");
            }
            catch (Exception ex)
            {
                // Log the exception details
                // Logger.LogError(ex.ToString());

                return BadRequest($"Error adding person data: {ex.Message}");
            }
        }
        [HttpGet("GetPersonsbyID")]
        public async Task<IActionResult> GetPersonById(int id)
        {
            try
            {
                // Read existing data from the JSON file
                var existingPersons = await ReadPersonsFromFile();

                // Find the person with the specified ID
                var person = existingPersons.FirstOrDefault(p => p.Id == id);

                if (person == null)
                {
                    return NotFound($"Person with ID {id} not found.");
                }

                return Ok(person);
            }
            catch (Exception ex)
            {
                // Log the exception details
                // Logger.LogError(ex.ToString());

                return BadRequest($"Error retrieving person data: {ex.Message}");
            }
        }

        [HttpGet("Get")]
        public async Task<IActionResult> GetAllPersons()
        {
            try
            {
                // Read existing data from the JSON file
                var existingPersons = await ReadPersonsFromFile();

                return Ok(existingPersons);
            }
            catch (Exception ex)
            {
                // Log the exception details
                // Logger.LogError(ex.ToString());

                return BadRequest($"Error retrieving all persons data: {ex.Message}");
            }
        }

        [HttpGet("filter")]
        public async Task<IActionResult> GetPersonsByFilter([FromQuery] PersonFilterParameters filters)
        {
            try
            {
                // Read existing data from the JSON file
                var existingPersons = await ReadPersonsFromFile();

                // Apply filters based on query parameters
                var filteredPersons = ApplyFilters(existingPersons, filters);

                return Ok(filteredPersons);
            }
            catch (Exception ex)
            {
                // Log the exception details
                // Logger.LogError(ex.ToString());

                return BadRequest($"Error retrieving filtered persons data: {ex.Message}");
            }
        }
        private List<AddPerson> ApplyFilters(List<AddPerson> persons, PersonFilterParameters filters)

        {
            // Implement your logic to filter persons based on query parameters
            // Example: Filter by City
            if (!string.IsNullOrEmpty(filters.City))
            {
                persons = persons.Where(p => p.PersonAddress?.City == filters.City).ToList();
            }
            if (!string.IsNullOrEmpty(filters.JobPosition))
            {
                persons = persons.Where(p => p.JobPosition == filters.JobPosition).ToList();
            }

            if (filters.MinSalary.HasValue)
            {
                persons = persons.Where(p => p.Salary >= filters.MinSalary).ToList();
            }

            if (filters.MaxSalary.HasValue)
            {
                persons = persons.Where(p => p.Salary <= filters.MaxSalary).ToList();
            }


            return persons;
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonById(int id)
        {
            try
            {
                // Read existing data from the JSON file
                var existingPersons = await ReadPersonsFromFile();

                // Find the person with the specified ID
                var personToDelete = existingPersons.FirstOrDefault(p => p.Id == id);

                if (personToDelete == null)
                {
                    return NotFound($"Person with ID {id} not found.");
                }

                // Remove the person from the list
                existingPersons.Remove(personToDelete);

                // Write updated data back to the JSON file
                await WritePersonsToFile(existingPersons);

                // Return the remaining data after deletion
                return Ok(existingPersons);
            }
            catch (Exception ex)
            {
                // Log the exception details
                // Logger.LogError(ex.ToString());

                return BadRequest($"Error deleting person data: {ex.Message}");
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonById(int id, [FromBody] AddPerson updatedPerson)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid data. Please check the input.");
                }

                // Read existing data from the JSON file
                var existingPersons = await ReadPersonsFromFile();

                // Find the person with the specified ID
                var existingPerson = existingPersons.FirstOrDefault(p => p.Id == id);

                if (existingPerson == null)
                {
                    return NotFound($"Person with ID {id} not found.");
                }

                // Replace all data of the existing person with the new data
                existingPersons[existingPersons.IndexOf(existingPerson)] = updatedPerson;

                // Write updated data back to the JSON file
                await WritePersonsToFile(existingPersons);

                // Return the updated data
                return Ok(existingPersons);
            }
            catch (Exception ex)
            {
                // Log the exception details
                // Logger.LogError(ex.ToString());

                return BadRequest($"Error updating person data: {ex.Message}");
            }
        }
        private async Task<List<AddPerson>> ReadPersonsFromFile()
        {
            try
            {
                using var fileStream = new FileStream(JsonFilePath, FileMode.OpenOrCreate, FileAccess.Read);
                var content = await JsonSerializer.DeserializeAsync<List<AddPerson>>(fileStream);
                return content ?? new List<AddPerson>();
            }
            catch (JsonException ex)
            {
                // Log the exception details
                // Logger.LogError(ex.ToString());
                return new List<AddPerson>();
            }
        }
        private async Task WritePersonsToFile(List<AddPerson> persons)
        {
            try
            {
                using (var fileStream = new FileStream(JsonFilePath, FileMode.Create, FileAccess.Write))
                using (var streamWriter = new StreamWriter(fileStream))
                {
                    var jsonSerializerOptions = new JsonSerializerOptions
                    {
                        WriteIndented = true
                    };

                    var json = JsonSerializer.Serialize(persons, jsonSerializerOptions);

                    await streamWriter.WriteAsync(json);
                    await streamWriter.FlushAsync();
                }
            }
            catch (Exception ex)
            {
                // Log the exception details
                // Logger.LogError(ex.ToString());
                throw; // Rethrow the exception to propagate it up the call stack if needed
            }
        }
    }
}
