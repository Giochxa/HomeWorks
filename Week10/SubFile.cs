using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10
{
    public class SubFile : FileWorker
    {
        private string extension = "exe";

        public override string Extension 
        {
            get => extension;
            set => extension = value !="" ? value : throw new ArgumentOutOfRangeException(nameof(value), "Extension must not be empty");
        }
        public override void Read()
        {
            base.Read();
        }
        public override void Write()
        {
            base.Write();
        }
        public override void Edit()
        {
            base.Edit();
        }
        public override void Delete()
        {
            base.Delete();
        }
    }
}
