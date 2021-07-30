namespace ExtractClassTest
{
    public class TelePhone
    {
        private string _areaCode;
        private string _number;

        public string GetAreaCode()
        {
            return this._areaCode;
        }

        public string GetNumber()
        { 
            return this._number;
        }

        public string Get()
        {
            return $"{this._areaCode}{this._number}";
        }

        public void SetAreaCode(string input)
        {
            this._areaCode = input;
        }

        public void SetNumber(string input)
        {
            this._number = input;
        }
    }
}