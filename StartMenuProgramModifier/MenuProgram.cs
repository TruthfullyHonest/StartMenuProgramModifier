namespace StartMenuProgramModifier
{
    public class MenuProgram
    {
        string Name;

        string Location;

        string Arguments;

        public MenuProgram()
        {
            Name = "";
            Location = "";
            Arguments = "";
        }

        public MenuProgram(string Name, string Location, string Arguments)
        {
            this.Name = Name.Substring(0, Name.LastIndexOf('.'));
            this.Location = Location;
            this.Arguments = Arguments;
        }

        public override string ToString()
        {
            return Name;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetLocation()
        {
            return Location;
        }

        public string GetArguments()
        {
            return Arguments;
        }

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public void SetLocation(string Location)
        {
            this.Location = Location;
        }

        public void SetArguments(string Arguments)
        {
            this.Arguments = Arguments;
        }
    }
}
