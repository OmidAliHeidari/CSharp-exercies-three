// doğum tarihi girilen kişinin yaşını hesaplama
Console.Write("Lütfen doğum tarihini (gün.ay.yıl) gir: ");
DateTime birthDay = Convert.ToDateTime(Console.ReadLine());

TimeSpan ageCalculator = (DateTime.Now - birthDay);
Console.WriteLine(ageCalculator.Days / 365);