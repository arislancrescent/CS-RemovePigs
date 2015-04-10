using ICities;

namespace RemovePigs
{
    public class Identity : IUserMod
    {
        public string Name
        {
            get { return Settings.Instance.Tag; }
        }

        public string Description
        {
            get { return "Nonpermanently removes all pigs. Disable to get the pigs back."; }
        }
    }
}