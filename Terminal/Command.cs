namespace Terminal
{
    public class Command
    {
        public Command(string name, string desc, CmdFunc func)
        {
            this.name = name;
            this.description = desc;
            this.function = func;
        }
        
        public string name;
        public string description;

        public delegate void CmdFunc();
        public CmdFunc function;
    }
}