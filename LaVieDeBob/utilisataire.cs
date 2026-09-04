using System;

namespace LaVieDeBob;

public static class Utilisataire
{
	public static DateTime Passerletemps(DateTime datetime, int temps)
	{
		return datetime.AddHours(temps);
	}
}
