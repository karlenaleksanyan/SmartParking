namespace SmartParking.Smart
{
    class Wallet
    {

        public int Price
        {
            get
            {
                return ((Camera.CloseData - Camera.openData).Hours + 1) * 100;
            }
            set { }
        }

        public override string ToString()
        {
            return $"Your price - {Price} AMD\n";
        }

        public override bool Equals(object obj)
        {
            return obj is Wallet wallet &&
                    Price == wallet.Price;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
