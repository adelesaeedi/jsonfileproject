using schoolNegin;
namespace informationschooljson
{
    public class GetKey
    {

        public static string keypath(string jsonfile)
        {

            string pathclass = schoolNegin.Pathclass.GetPath();
            switch (jsonfile) 
            {
                case "classsaval": 
                string aval = pathclass + "jsonfile\\classsavalkey.json";
                    break;
                case "classsdovom":
                string dovom = pathclass + "jsonfile\\classsdovomkey.json";
                    break;
                ;
            

            }
            return pathclass;


        }
                
                
    }
}   
