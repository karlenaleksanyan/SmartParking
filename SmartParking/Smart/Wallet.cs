namespace SmartParking.Smart
{
	class Wallet:Camera
	{

		public int Price
		{
			get
			{
				return (((CloseData - OpenData).Minutes) / 60) + 1 * 100;
			}
			private set { }
		}

		public override string ToString()
		{
			return $"Your price - {Price} AMD";
		}

		public override bool Equals(object obj)
		{
			return obj is Wallet wallet &&
				    Price==wallet.Price;
		}
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}
