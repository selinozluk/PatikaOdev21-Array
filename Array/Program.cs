// 1 - 10 adet tam sayı verisi alacak bir dizi

// Diziler 0'dan başladığı için 10 sayı için 0-10 arası toplam 11 eleman olur
int[] numbers = new int[11];


// 2 - Dizinin elemanlarını bir for döngüsü ile doldurup, foreach döngüsü ile tekrar ekrana yazdırır

for (int i = 0; i < 10; i++)
{
    Console.Write($"{i + 1}. sayıyı giriniz: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("---------------------------------------------");


Console.WriteLine("Girilen ilk 10 sayı (foreach ile):");

int counter = 0;
foreach (int number in numbers)
{
    if (counter == 10)
        break; // 10. elemandan sonra durur
    Console.WriteLine(number);
    counter++;
}

// 3- Bu diziye kullanıcıdan alınan yeni bir değeri ekler (11. eleman olarak)

Console.Write("11. sayıyı giriniz: ");
numbers[10] = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("----------------------------------------------");


// 4 - Bu diziyi büyükten küçüğe ekrana yazdırır 

Array.Sort(numbers);      // Küçükten büyüğe sıralar
Array.Reverse(numbers);   // Ters çevirerek büyükten küçüğe yapar


Console.WriteLine("Büyükten küçüğe sıralanmış liste:");
foreach (int number in numbers)
{
    Console.WriteLine($"{number}");
}