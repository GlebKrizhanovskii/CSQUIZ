using System;

namespace Example {

    public class ex_program
    {
        
	    public void program() {
            programlogic mainprog = new programlogic();

            mainprog.somefunc();

        }



    };


    public class programlogic {
        public programlogic() {
            
            hndler = new publicclass();
        
        }

        idatahandler hndler;


        public void somefunc() {
            while (true)
            {
                //input

                hndler.check_if_user_exists();
                // ...
            }
        }

    }

    interface idatahandler {
        void check_if_user_exists();
        void new_func_to_improve_usability();

    };

    public class publicclass : idatahandler {

        public publicclass() {
            collection = null;
        }

        public void check_if_user_exists() { 
        
        }

        public void new_func_to_improve_usability() { 
        
        }

        private ConsoleApp1.Program.UsersCollection collection;
    }

};
