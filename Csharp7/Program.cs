
int toplam = 0;

Console.WriteLine("İlk sayıyı giriniz");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İkinci sayıyı giriniz");
int b = Convert.ToInt32(Console.ReadLine());

for (int i = a+1; i < b; i++)
{
    toplam = toplam + i;
}
Console.WriteLine($"İki sayı arasındaki sayıların toplamı = {toplam} ");



