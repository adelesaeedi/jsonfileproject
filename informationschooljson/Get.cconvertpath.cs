
using Newtonsoft.Json;
namespace informationschooljson
{

    public  class Convertpath


          
    {
        string Path = @"\jsonfile\classsavalkey.json";
        public Convertpath(string path) {
            this.Path = Path;
        }
        public classaval GetClassAval()
        {
            var json = GetClassJson("classaval");
            var jsonObject = JsonConvert.DeserializeObject<classaval>(json);
            return jsonObject;
        }
        public classaval GetClassDovom()
        {
            var json = GetClassJson("classDovom");
            var jsonObject = JsonConvert.DeserializeObject<classaval>(json);
            return jsonObject;
        }
        public string GetClassJson(string fileName)
        {
            var filecontent = System.IO.File.ReadAllText(@$"\jsonfile\{fileName}.json");
            return filecontent;

        }

    }
}
