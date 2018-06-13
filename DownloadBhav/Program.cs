using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DownloadBhav
{
    class Program
    { 


        public  static void Stock()
        {
            string date = DateTime.Now.Day.ToString();
            string month = DateTime.Now.ToString("MMM").ToUpper();
            string Year = DateTime.Now.Year.ToString();
            string monthnumber = DateTime.Now.ToString("MM");
            string createUrl = "https://www.nseindia.com/content/historical/EQUITIES/" + Year + "/" + month + "/" + "cm" + date + month + Year + "bhav.csv.zip";
            string fileName = "cm" + date + month + Year + "bhav.csv.zip";

            string firsname = "https://nseindia.com";
            //int pos = firsname.LastIndexOf("/") + 1;
            //string finalName = firsname.Substring(pos, firsname.Length - pos);
            Dictionary<string, string> getall = new Dictionary<string, string>();
            getall.Add("BhavCSV", "/content/historical/EQUITIES/2018/MAY/cm" + date + month + Year + "bhav.csv.zip");
            getall.Add("BhavPr", "/archives/equities/bhavcopy/pr/PR" + date + monthnumber + Year.Substring(Year.Length - 2) + ".zip");
            getall.Add("MarketActivityReport", "/archives/equities/mkt/MA" + date + monthnumber + Year.Substring(Year.Length - 2) + ".csv");
            getall.Add("SecurityWiseDelivery", "/archives/equities/mto/MTO_" + date + monthnumber + Year + ".DAT");
            getall.Add("ListOfsecurityaction", "/content/nsccl/AUB_2018105_" + date + monthnumber + Year + ".csv");
            getall.Add("PricebankChange", "/content/equities/eq_band_changes_" + date + monthnumber + Year + ".csv");
            getall.Add("SettlementStatics", "/content/nsccl/Daily_Settlement_Statistics_" + date + monthnumber + Year + ".doc");
            //s getall.Add("CategoryWsieTurnOver", "/archives/equities/cat/cat_turnover_" + date + monthnumber + Year.Substring(Year.Length - 2) + ".xls");
            getall.Add("STTNonApp", "/content/equities/C_STT_" + date + monthnumber + Year + ".csv");
            getall.Add("STTEQUITY", "/content/equities/C_STT_IND_" + date + monthnumber + Year + ".csv");
            getall.Add("DailyVolatity", "/archives/nsccl/volt/CMVOLT_" + date + monthnumber + Year + ".CSV");
            getall.Add("BulkDeal", "/content/equities/bulk.csv");
            getall.Add("BlockDeal", "/content/equities/block.csv");
            getall.Add("CloseOutPrices", "/archives/equities/csqr/CSQR_N2018105_" + date + monthnumber + Year + ".csv");
            getall.Add("DailyVolatitty", "/archives/nsccl/volt/CMVOLT_" + date + monthnumber + Year + ".CSV");
            getall.Add("ShortSell", "/content/equities/ShortSelling.csv");
            getall.Add("CorporateBindTraded", "/archives/equities/corpbond/corpbond" + date + monthnumber + Year.Substring(Year.Length - 2) + ".csv");


            string yourDirectory = "D:\\DOWNLOADBHAV\\Consolidate\\'" + date + month + Year + "\\" + "'Stock\\" + "Consolidate_" + (DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year);
            if (!Directory.Exists(yourDirectory))
            {
                Directory.CreateDirectory(yourDirectory);
            }
            foreach (var item in getall)
            {
                int pos = item.Value.LastIndexOf("/") + 1;
                string finalName = item.Value.Substring(pos, item.Value.Length - pos);
                if (!Directory.Exists(yourDirectory + "\\" + item.Key))
                    Directory.CreateDirectory(yourDirectory + "\\" + item.Key);

                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(firsname + item.Value, yourDirectory + "\\" + item.Key + "\\" + finalName);
                }

            }
        }

        public static void FNO()
        {

            string date = DateTime.Now.ToString("dd");
            string month = DateTime.Now.ToString("MMM").ToUpper();
            string Year = DateTime.Now.Year.ToString();
            string monthnumber = DateTime.Now.ToString("MM");
            string createUrl = "https://www.nseindia.com/content/historical/DERIVATIVES/" + Year + "/" + month + "/" + "fo" + date + month + Year + "bhav.csv.zip";
            string fileName = "cm" + date + month + Year + "bhav.csv.zip";

            string firsname = "https://nseindia.com";
            //int pos = firsname.LastIndexOf("/") + 1;
            //string finalName = firsname.Substring(pos, firsname.Length - pos);
            Dictionary<string, string> getall = new Dictionary<string, string>();
            getall.Add("BhavCSV", "/content/historical/DERIVATIVES/2018/JUN/fo" + date + month + Year + "bhav.csv.zip");
            getall.Add("BhavZIP", "/archives/fo/bhav/fo" + date + month + Year + "bhav.csv.zip");
            //getall.Add("BhavPr", "/archives/equities/bhavcopy/pr/PR" + date + monthnumber + Year.Substring(Year.Length - 2) + ".zip");
            getall.Add("MarketActivityReport", "/archives/fo/mkt/fo" + date + monthnumber + Year.Substring(Year.Length - 2) + ".csv");
            getall.Add("Daily Settlement Price files", "/archives/nsccl/sett/FOSett_prce_" + date + monthnumber + Year + ".csv");
            getall.Add("Daily Client wise Position Limits", "/archives/nsccl/cli/oi_cli_limit_" + date +"-"+ monthnumber +"-ss"+ Year + ".csv");
            getall.Add("Security in ban period", "/archives/fo/sec_ban/fo_secban_" + date + monthnumber + Year + ".csv");
            getall.Add("NSE Open Interest", "/archives/nsccl/mwpl/nseoi_" + date + monthnumber + Year + ".zip");
            getall.Add("Combine Open Interest", "/archives/nsccl/mwpl/combineoi_" + date + monthnumber + Year + ".zip");
            getall.Add("Category wise turnovers", "/archives/fo/cat/fo_cat_turnover_" + date + monthnumber + Year + ".xls");
            getall.Add("Clients Position % greater than equal to 3% of Stock MWPL", "/content/nsccl/mwpl_cli_" + date + monthnumber + Year + ".xls");
            getall.Add("Participant wise Trading Volumes", "/content/nsccl/fao_participant_vol_" + date + monthnumber + Year + ".csv");
            getall.Add("Participant wise Open Interest", "/content/nsccl/fao_participant_oi_" + date + monthnumber + Year + ".csv");
            getall.Add("Top 10 Clearing Member VolumesL", "/content/nsccl/fao_top10cm_to_" + date + monthnumber + Year + ".csv");
            getall.Add("FII Derivative Stats", "/content/fo/fii_stats_" + date +"-"+ monthnumber +"-"+ Year + ".xls");
            getall.Add("Exposure Limit File", "/archives/exp_lim/ael_" + date + "-" + monthnumber + "-" + Year + ".csv");
            getall.Add("SPAN Risk Parameter files1", "/archives/nsccl/span/nsccl." + date + "-" + monthnumber + "-" + Year + ".csv");
            getall.Add("SPAN Risk Parameter files2", "/archives/exp_lim/ael_" + date + "-" + monthnumber + "-" + Year + ".csv");
            

            string yourDirectory = "D:\\DOWNLOADBHAV\\Consolidate\\'" + date + month + Year + "\\" + "'FNO\\" + "Consolidate_" + (DateTime.Now.Day + "_" + DateTime.Now.Month + "_" + DateTime.Now.Year);
            if (!Directory.Exists(yourDirectory))
            {
                Directory.CreateDirectory(yourDirectory);
            }
            foreach (var item in getall)
            {
                int pos = item.Value.LastIndexOf("/") + 1;
                string finalName = item.Value.Substring(pos, item.Value.Length - pos);
                if (!Directory.Exists(yourDirectory + "\\" + item.Key))
                    Directory.CreateDirectory(yourDirectory + "\\" + item.Key);

                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(firsname + item.Value, yourDirectory + "\\" + item.Key + "\\" + finalName);
                }

            }
        }
        static void Main(string[] args)
        {
          //  Stock();
            FNO();
         
        }
    }
}
