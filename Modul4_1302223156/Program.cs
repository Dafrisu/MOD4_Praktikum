// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class kodeBuah {
    public enum buah {Apel,Aprikot,Alpukat,Pisang,Paprika,Blackberry,Ceri,Kelapa,Jagung};
    public enum kode { A00, B00, C00, D00, E00, F00, G00, H00, I00, J00 };
    public void GetKodeBuah() {
        Console.WriteLine("Nama Buah -- Kode Buah");
        for (int i=0; i < 9; i++) {
            string output = ((buah)i).ToString().PadRight(15);
            Console.WriteLine(output+"\t"+((kode)i).ToString());
            Console.WriteLine();
        }
        }
}

public class posisiKarakterGame {
    public enum posisi { 
        Jongkok,
        Berdiri,
        Tengkurap,
        Terbang
    }
    private posisi currentstate;

    public posisiKarakterGame() {
        currentstate = posisi.Berdiri;
        Console.WriteLine("Posisi standby");
    }
    public void posisiBerdiri() {
        currentstate = posisi.Berdiri;
        Console.WriteLine("Posisi standby");
    }
    public void posisiTengkurap()
    {
        currentstate = posisi.Tengkurap;
        Console.WriteLine("Posisi istirahat");
    }
}
class program { 
    static void Main(string[] args)
    {
        kodeBuah namaBuah = new kodeBuah();
        namaBuah.GetKodeBuah();

        posisiKarakterGame karakter = new posisiKarakterGame();
        karakter.posisiTengkurap();
        karakter.posisiBerdiri();
        

    }
}
