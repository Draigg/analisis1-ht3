using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace V2
{
    class Decorator
    {
        public void funcCommandLine(string[] args){
            Facade cmd = new Facade();

            if(args.Contains("HTML")){
                cmd.commandHTML(args);  
            }else if(args.Contains("JSON")){
                cmd.commandJSON(args);  
            }else if(args.Contains("CSV")){
                cmd.commandCSV(args);  
            }else if(args.Contains("XML")){
                cmd.commandXML(args);  
            }

        }
    }
}
