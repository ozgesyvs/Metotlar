using System;
using System.Security.Cryptography.X509Certificates;
namespace metot{


class Metot{

static void Main(string[] args){


   
int topla = sayiTopla(10,20);

Console.WriteLine(topla);



int a = 2;
int b = 3;

Console.WriteLine(a+b);


static int sayiTopla(int a,int b){

    
return a+b;

}


Methodlar method = new Methodlar();

method.yazdir(topla.ToString());

int sonuc2 = method.arttirveTopla(a,b);

method.yazdir(sonuc2.ToString());
method.yazdir((a+b).ToString());
method.yazdir(sonuc2.ToString());





/*

static bir class içerisinden sadece static
metotlar erişilebilir dolayısıyla
methodun başına static yazmalıyız
methodu static class dışına yazdıysak
static ifadesini kesin kullanmalıyız

*/







//Metotları bir programı parçalamak için kullanıyoruz

/*

metotlar tek başlarına yazılabilen/çağrılabilen
yapılar değildir bir class içerisinde yazılması gerekir
başka bir class'taki methoda o class'ın örneğini oluştururak
sonrasında erişebilirken
aynı sınıftaki methoda o methodun ismini yazarak erişebiliriz

metot yapısı:

erisim_belirteci geri_donustipi metotadı(parametrelistesi/arguman)

{




}

bir methodu public tanımlarsak her yerden
private tanımlarsak sadece aynı sınıftan erisilir

geri dönüş tipi bu method bir iş yaptıktan 
sonra geriye bir şey dönecek mi? sorusunu cevaplar
her methodun bir geri dönüş tipi olmak zorunda değildir
bu durumda void yazılır

parametre listesi : bu methodun is yaparken kullanacağı parametreler

*/



/*
referans vermek fonksiyona a ve b'nin değerlerini
değil de bellekteki karşılıklarını vermek demektir

mesela bir fonksiyona parametre olarak ref int a,ref int b verirsek
kopyalar üzerinde çalışmak yerine bizim başta tanımlamış olduğumuz
a ve b'nin değerini de değiştirecektir
mesela arttirveTopla fonksiyonunda gerçek a ve b'nin değerini
artık 1 artmış şekilde gösterir

method.arttirveTopla(ref a,ref b);
şeklinde çağırmalıyız çağırırken de

*/








}
}


class Methodlar{


public void yazdir(string veri){


Console.WriteLine(veri);


}


public int arttirveTopla(int sayi1,int sayi2){

    sayi1+=1;
    sayi2+=1;

    return sayi1+sayi2;

}






}




}


/*
erişim belirteci olarak bir şey
yazmazsak default olarak private atanır

method içine verdiğimiz parametreler
sadece o method içinden erişilebilir

*/