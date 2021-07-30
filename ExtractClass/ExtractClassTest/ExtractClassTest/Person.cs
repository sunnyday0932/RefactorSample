namespace ExtractClassTest
{
    public class Person
    {
        private string _name;
        private TelePhone _telePhone;

        public Person()
        {
            this._telePhone = new TelePhone();
        }

        public string GetName()
        {
            return this._name;
        }

        public void SetName(string input)
        {
            this._name = input;
        }

        public string GetOfficeAreaCode()
        {
            return this._telePhone.GetAreaCode();
        }

        public string GetOfficeNumber()
        {
            return this._telePhone.GetAreaCode();
        }

        public string GetTelePhoneNumber()
        {
            return this._telePhone.Get();
        }

        public void SetOfficeAreaCode(string input)
        {
            this._telePhone.SetAreaCode(input);
        }

        public void SetOfficeNumber(string input)
        {
            this._telePhone.SetNumber(input);
        }
    }
}
