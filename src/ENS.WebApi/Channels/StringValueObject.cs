namespace ENS.WebApi.Channels
{
    public class StringValueObject
    {
        public StringValueObject()
        {

        }

        public StringValueObject(string stringValue)
        {
            this.Value = stringValue;
        }

        public string Value { get; set; }

        public override string ToString()
        {
            return this.Value; 
        }
    }
}