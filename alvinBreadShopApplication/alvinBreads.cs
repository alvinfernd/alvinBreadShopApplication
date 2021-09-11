using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace alvinBreadShopApplication
{
    public class alvinBreads
    {
        private string name;
        private int price;
        private int stock;

        #region Contructors

        //Tambahkan construcotr berparameter pada class anda yang berfunsgi memberi nilai 
        //awal pada semua properties yang ada (kecuali read only properties - jika ada
        public alvinBreads(string breadName, int breadPrice)
        {
            this.Name = breadName;
            this.Price = breadPrice;
        }

        #endregion

        #region Properties

        //nama roti tidak boleh dikosongi
        public string Name 
        { 
            get => name;
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Name can not be empty");
                }
            }
        }

        //harga roti berkisar 10000 s/d 20000
        public int Price 
        { 
            get => price;
            set
            {
                if (value >= 10000 && value <= 20000)
                {
                    price = value;
                }
                else
                {
                    throw new Exception("Price must be 10000 - 20000");
                }
            }
        }

        //stock adalah read only property (karena hanya bisa diisi/diganti melalui method
        //jadi gunakan private set
        //stock tidak boleh negatif
        public int Stock 
        { 
            get => stock;
            private set
            {
                if (value >= 0)
                {
                    stock = value;
                }
                else
                {
                    throw new Exception("Stock can not be negative");
                }
            }
        }
        #endregion

        #region Methods
        public void Production(int quantity)
        {
            //quantity min. 10 pcs, max 50 pcs
            if (quantity >= 10 && quantity <= 50)
            {
                this.Stock += quantity;
            }
            else
            {
                throw new Exception("Quantity must be 10-50 pcs");
            }
        }

        public int Sell(int quantity, string paymentMethod)
        {
            //cek apakah stok mencukupi dan quantity harus > 0
            if (this.Stock >= quantity && quantity > 0)
            {
                this.Stock -= quantity;

                //hitung diskon quantity
                int discountQty = 0;

                //jika roti terjual > 5 mendapatkan diskon quantity 20%
                if (quantity > 5)
                {
                    discountQty = (int) (0.2 * quantity * this.Price);
                }

                //hitung total bayar setelah dikurangi diskon quantity
                int totalBayar = quantity * this.Price - discountQty;

                //jika membayar dengan credit card maka mendapat diskon pembayaran
                int diskonBayar = 0;
                if (paymentMethod == "Credit Card")
                {
                    diskonBayar = (int) (0.1 * totalBayar);
                }

                //hitung total bayar akhir
                totalBayar -= diskonBayar;

                return totalBayar;

            }
            else if (this.Stock < quantity)
            {
                throw new Exception("Not enough stock. Current stock = " + this.Stock);
            }
            else
            {
                throw new Exception("Quantity must be > 0");
            }
        }
        #endregion
    }
}