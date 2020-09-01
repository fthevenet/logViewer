using System;
using System.Collections.Generic;
using System.Text;


namespace IACLI.Core.Factory
{
   
    public class CommandInfoAttribute : Attribute
    {

        public CommandInfoAttribute(string commandKeyword, string commandDescription, string commandExample, string commandParameters)
            : this(commandKeyword, commandDescription, commandExample, new string[] {commandParameters}, false)
        {

        }

        public CommandInfoAttribute(string commandKeyword, string commandDescription, string commandExample, string[] commandParameters)
            :this(commandKeyword, commandDescription, commandExample, commandParameters, false)
        {
           
        }
        public CommandInfoAttribute(string commandKeyword, string commandDescription, string commandExample, string commandParameters, bool serverNotRequired)
            : this(commandKeyword, commandDescription, commandExample, new string[] { commandParameters }, serverNotRequired)
        {
        }

        public CommandInfoAttribute(string commandKeyword, string commandDescription, string commandExample, string[] commandParameters, bool serverNotRequired)
        {
            this.keyword = commandKeyword;
            this.parameters = commandParameters;
            this.description = commandDescription;
            this.example = commandExample;
            this.serverNotRequired = serverNotRequired;

        }

        private string keyword;
        private string[] parameters;
        private string description;
        private string example;
        private Type commandType;
        private bool serverNotRequired;

        public bool ServerNotRequired
        {          
            get { return serverNotRequired; }
        }
        
        public string CommandKeyword
        {
            get { return keyword; }          
        }

        public string CommandDescription
        {
            get { return description; }
        }

        public string[] CommandParameters
        {
            get { return parameters; }
        }

        public string CommandExample
        {
            get { return example; }
        }

        public Type CommandType
        {
            get { return commandType; }
            set { commandType = value; }
        }
        
    }

}
