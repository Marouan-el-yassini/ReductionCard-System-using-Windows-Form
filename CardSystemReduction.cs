using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CardSystem
{
    class Program
    {
        class Owner
        {
            public string FName { get; set; }
            public int _age;
            public int Age {
                get
                {
                    return _age;
                }
                set
                {
                    if (value < 18)
                    {
                        Console.WriteLine("Imposible");
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Validé!");
                        _age=value;
                    }
                }
            }
            public Guid id;
            public Owner(Guid id,string FName,int Age)
            {
                this.id = id;
                this.FName = FName;
                this.Age = Age;
            }
            public virtual void Info()
            {
                Console.WriteLine($"Merci {FName} -- {Age} ans -- [{id}] pour votre achat. Notre système va vérifier la réduction nécessaire.");
            }
        }

        class CardR :Owner
        {
            public double PrixAchat { get; set; }
            public double _prixReduction;
            public double PrixReduction {
                set
                {
                    if(Age>18 && Age < 22)
                    {
                        Console.WriteLine("Vous êtes étudiant : réduction de 50%.");
                        _prixReduction = PrixAchat * 50 / 100;
                    }
                    else if(Age>=22 && Age < 60)
                    {
                        Console.WriteLine("Acune reduction 0%");
                        _prixReduction = 0;
                    }
                    else if (Age >= 60)
                    {
                        Console.WriteLine("Vous êtes retraité : réduction de 80%.");
                        _prixReduction = PrixAchat * 80 / 100;
                    }
                }
                get
                {
                    return _prixReduction;
                }
            }

            public CardR(Guid id, string FName, int Age,double PrixAchat) : base(id, FName, Age)
            {
                this.PrixAchat = PrixAchat;
                this.PrixReduction = 0;
            }
            
            public double total()
            {
                return PrixAchat - PrixReduction;
            }
            public override void Info()
            {
                base.Info();
                Console.WriteLine("");
                Console.WriteLine($"✅ Commande validée ! Merci encore. Votre prix total est : {total()} DH.");
            }

        }
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================================");
            Console.WriteLine("🛒 Bienvenue dans notre Store");
            Console.WriteLine("======================================");
            Console.ResetColor();

            Console.Write("👉 Entrez votre nom: ");
            string Name = Console.ReadLine();

            Console.Write("👉 Entrez le produit: ");
            string Produit = Console.ReadLine();

            Console.Write("👉 Entrez votre âge: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("👉 Entrez le prix du produit (DH): ");
            double Prix = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n✅ Merci pour vos informations, traitement en cours...\n");

            CardR cr = new CardR(Guid.NewGuid(), Name, age, Prix);
            cr.Info();
        }
    }
}
