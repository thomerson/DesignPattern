namespace 过滤器模式
{
    public class Person
    {

        public Person(string name, string gender, string maritalStatus)
        {
            this.Name = name;
            this.Gender = gender;
            this.MaritalStatus = maritalStatus;
        }

        public string Name { get; private set; }

        public string Gender { get; private set; }
        public string MaritalStatus { get; private set; }
    }
}
