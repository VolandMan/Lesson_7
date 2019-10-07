using System;

namespace ConsoleApp7
{
    class Product
    {
        string name;
        int price;
        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public Product(string rname)
        {
            this.name = rname;
        }

        public string getName()
        {
            return name;
        }
        public int getPrice()
        {
            return price;
        }
    }
    class Cart
    {
        Product[] products = new Product[10];
        public void addProduct(Product product) // добавление в корзину
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] == null)
                {
                    products[i] = product;
                    break;
                } 
            }
        }
            public void RemProduct(string rname) // удаление товара из крозины
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].getName() == rname)
                {
                    products[i] =null;
                   
                }
                
              //  else
             //   {
              //      Console.WriteLine($"Продукт отсутствует в корзине");  Ошибка при проверке ((   исправить.
           //     }
            }
        }
        public void showCart() // Вывод корзины на экран
        {
            Console.WriteLine("В корзине:");
            int total = 0;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] != null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t"+ products[i].getName() + " : " + products[i].getPrice());
                    total += products[i].getPrice();
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tCART TOTAL: " + total);
        }
        class Program
        {
            static void Main(string[] args)
            {
                {
                    int button;
                    Cart cart = new Cart();
                    do
                    {
                        //меню выбора 
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n*******Покупки в магазине******" +
                        "\n 1- Добавить продукт в корзину" +
                        "\n 2- Удалить продукт из корзины" +
                        "\n 3- Вывести информацию по корзине" +
                        "\n 0- Завершения покупок \n==============================");

                            button = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                                             
                            switch (button)
                            {
                            // Добавление продукта
                                case 1:
                                Console.WriteLine($"Введите наименование товара");
                                string name = Console.ReadLine();
                                Console.Write($"Введите цену {name} = ");
                                int price = Convert.ToInt32(Console.ReadLine());
                                Product p = new Product(name, price);
                                cart.addProduct(p);
                                cart.showCart(); 
                                 
                                   break;
                                case 2: // Удаление товара
                                Console.WriteLine("Введите не нужный вам товар");
                                string rname = Console.ReadLine();
                                cart.RemProduct (rname);
                                   break;
                               
                                case 3:  // Вывести стоймость покупок
                                cart.showCart();
                                    break;
                                //Выход
                                case 0:
                                    Environment.Exit(0);
                                    break;
                            //если другая цифра
                            default:
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("ПУНКТ МЕНЮ ОТСУТСТВУЕТ!!");
                                break;
                            }
                     
                    } while(button != 0) ;
                    //чтобы консоль не закрылась
                    Console.ReadKey();
                }
            }
        }
    }
}