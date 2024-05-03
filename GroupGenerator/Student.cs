namespace GroupGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Student : Person, IDisplayConfig
    {
        public Student(string name)
            : base(name)
        {
        }

        public Student(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int DisplayModeFullNameWithId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
