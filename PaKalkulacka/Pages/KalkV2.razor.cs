namespace PaKalkulacka.Pages
{
	public partial class KalkV2
	{
		private short cislo1 = 1;
		private short cislo2;
		private short vysledek;
		private string chybaText = "";

		public short Cislo1
		{
			get => cislo1; 
			set
			{
				cislo1 = value;
				chybaText = "";
			}
		}

		public short Cislo2
		{
			get => cislo2; 
			set
			{
				cislo2 = value;
				chybaText = "";
			}
		}

		private void Soucet()
		{
			
			try
			{
				checked
				{
					vysledek = (short)(Cislo1 + Cislo2);
				}
			}
			catch (Exception)
			{

				chybaText = $"Došlo k přetečení. Hodnota {Cislo1 + Cislo2} je větší {short.MaxValue}";
			}

		}
		private void Rozdil()
		{
			vysledek = (short)(Cislo1 - Cislo2);
		}
		private void Soucin()
		{
			vysledek = (short)(Cislo1 * Cislo2);
		}
		private void Podil()
		{
			vysledek = (short)(Cislo1 / Cislo2);
		}

	}
}
