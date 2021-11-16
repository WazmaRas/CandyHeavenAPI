using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyHeavenAPI.Data
{
    public class ProductManager
    {
        public static List<Models.ProductModel> GetProductList()
        {
            
         
                List<Models.ProductModel>products = new List<Models.ProductModel>();

                products.Add(new Models.BarModel(1, "Barmony Salted Caramel", "En balanserad snackbar av nötter med inslag av salted caramel.", false, 17.00, "https://candypeople.se/wp-content/uploads/2020/06/barmony-caramel-300x232.jpg", 100, "salted caramel"));
                products.Add(new Models.BarModel(2, "Barmony Pecan/Sea Salt", "En balanserad snackbar av nötter.", false, 17.00, "https://candypeople.se/wp-content/uploads/2019/05/barmony_pecan-300x232.jpg", 100, "pecan/seasalt"));
                products.Add(new Models.BarModel(3, "Barmony Salty Chocolate", "En balanserad snackbar av nötter med chokladdragerad undersida.", false, 17.00, "https://candypeople.se/wp-content/uploads/2019/05/barmony_saly_chocolate-300x232.jpg", 100, "saltchoklad"));
                products.Add(new Models.BarModel(4, "Flapjack Berrylicious", "En bakad bar gjord av främst havre och sirap med inslag av torkade bär.", false, 19.90, "https://candypeople.se/wp-content/uploads/2019/05/50387_Flapjack_berry-300x232.jpg", 100, "bärsmak"));
                products.Add(new Models.BarModel(5, "Flapjack Pistachio", "En bakad bar gjord av främst havre och sirap med inslag av pistachnöt.", false, 19.90, "https://candypeople.se/wp-content/uploads/2019/05/50385_flapjack_pistachio-300x232.jpg", 100, "pistage"));
                products.Add(new Models.BarModel(6, "Flapjack Dark Chocolate", "En balanserad snackbar av nötter med chokladdragerad undersida.", false, 19.90, "https://candypeople.se/wp-content/uploads/2019/05/50385_flpajack_darkchocolate-300x232.jpg", 100, "salty chocolate"));
                products.Add(new Models.CandyBagModel(7, "Frukttoppar", "Dragerat skumgodis med smak av jordgubbe, päron och persika/aprikos.", true, 15.90, "https://candypeople.se/wp-content/uploads/2017/10/113300_Frukttoppar_140g_utan_logga-300x232.jpg", 100, 120));
                products.Add(new Models.CandyBagModel(8, "Jordnötsringar", "Krispiga jordnötsringar doppade i mjölkchoklad.", true, 29.90, "https://candypeople.se/wp-content/uploads/2020/11/50420_Chokladdoppade_Jordn%C3%B6tsringar-300x232.jpg", 100, 120));
                products.Add(new Models.CandyBagModel(9, "S-märken Supersurt", "S-märken är ett gelegodis med supersurt sockeröverdrag.", true, 9.90, "https://candypeople.se/wp-content/uploads/2015/09/supersurt-300x225.jpg", 25, 120));
                products.Add(new Models.CandyBagModel(10, "S-märken Supersalt", "S-märke Supersalt är en lakritsgelegodis med supersalt överdrag.", false, 9.90, "https://candypeople.se/wp-content/uploads/2015/09/supersalt-300x225.jpg", 25, 120));
                products.Add(new Models.CandyBagModel(11, "Sura Colanappar", "Sura vingumminappar med en riklig smak utav cola tillsammans med syrligt sockeröverdrag. Produkten är vegansk.", false, 9.90, "https://candypeople.se/wp-content/uploads/2017/10/50135_Originals_SuraColanappar_80g-300x232.jpg", 25, 120));
                products.Add(new Models.BulkCandyModel(12, "Smultronmatta", "", false, 99.00, "https://candypeople.se/wp-content/uploads/2015/04/smultron_matta-300x225.jpg", 25, "smultron"));
                products.Add(new Models.BulkCandyModel(13, "Söt lakritsmatta", "", false, 159.00, "https://candypeople.se/wp-content/uploads/2015/04/lakrits_matta-300x225.jpg", 25, "sötlakrits"));
                products.Add(new Models.BulkCandyModel(14, "Lakritsbitar", "Ibland är allt som krävs för en lyckad kväll 2.2 kg lakrits i storpack! Säkra din låda redan idag så du inte sitter lakritslös på lördag!", false, 199.00, "https://candypeople.se/wp-content/uploads/2015/04/lakrits_bitar-300x225.jpg", 25, "lakrits"));
                products.Add(new Models.BulkCandyModel(15, "Jordgubbsrolls", "Ihoprullade godisremsor med mumsig jordgubbssmak att köpa hem lagom till storkalaset eller om du vill bunkra upp med massa godis så du har för ett par fredagsmystillfällen framöver.", false, 99.00, "https://candypeople.se/wp-content/uploads/2015/04/jordgubbs_rolls-300x225.jpg", 25, "jordgubb"));
                products.Add(new Models.BulkCandyModel(16, "Frukttoppar", "Ihoprullade godisremsor med mumsig jordgubbssmak att köpa hem lagom till storkalaset eller om du vill bunkra upp med massa godis så du har för ett par fredagsmystillfällen framöver.", false, 99.00, "https://candypeople.se/wp-content/uploads/2015/04/frukt_toppar1-300x225.jpg", 25, "fruktsmak"));

        
                 return products;


        }
    }
}
