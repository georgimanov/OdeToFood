namespace OdeToFood.Controllers
{
    using OdeToFood.ActionConstraints;

    public class AboutController
    {
        public string Phone()
        {
            return "02/9630000";
        }

        public string Address()
        {
            return "Sofia/Bulgaria";
        }

        [IsMobile]
        public string Contacts()
        {
            return "Mobile: Sofia/Bulgaria";
        }
    }
}
