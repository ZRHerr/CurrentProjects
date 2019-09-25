class User
{
    readonly string cipher;
    readonly string username;
    public User(string name, string pass)
    {
        username = name;
        cipher = Encrypt(pass);
    }
    //take the password user enter for user and ecrypt and return that will be stored in our cipher string.
    public string Encrypt(string password)
    {
        password = password.ToLower();
        char[] ch = password.ToCharArray();
        string encrypted = "";
        for (int i = 0; i < password.Length; i++)
        {
            switch (ch[i])
            {
                case 'a':
                    encrypted +=  "{";
                    break;
                case 'b':
                    encrypted +=  "}";
                    break;
                case 'c':
                    encrypted +=  "#";
                    break;
                case 'd':
                    encrypted += "~";
                    break;
                case 'e':
                    encrypted += "+";
                    break;
                case 'f':
                    encrypted +=  "-";
                    break;
                case 'g':
                    encrypted += "*";
                    break;
                case 'h':
                    encrypted +=  "@";
                    break;
                case 'i':
                    encrypted +=  "/";
                    break;
                case 'j':
                    encrypted +=  "\\";
                    break;
                case 'k':
                    encrypted += "?";
                    break;
                case 'l':
                    encrypted +=  "$";
                    break;
                case 'm':
                    encrypted += "!";
                    break;
                case 'n':
                    encrypted += "^";
                    break;
                case 'o':
                    encrypted +=  "(";
                    break;
                case 'p':
                    encrypted +=  ")";
                    break;
                case 'q':
                    encrypted +=  "<";
                    break;
                case 'r':
                    encrypted += ">";
                    break;
                case 's':
                    encrypted +=  "=";
                    break;
                case 't':
                    encrypted +=  ";";
                    break;
                case 'u':
                    encrypted +=  ",";
                    break;
                case 'v':
                    encrypted +=  "_";
                    break;
                case 'w':
                    encrypted += "[";
                    break;
                case 'x':
                    encrypted += "]";
                    break;
                case 'y':
                    encrypted +=  ":";
                    break;
                case 'z':
                    encrypted +=  "\"";
                    break;
                case ' ':
                    encrypted += " ";
                    break;
                case '.':
                    encrypted += '3';
                    break;
                case ',':
                    encrypted +=  "1";
                    break;
                case '(':
                    encrypted += '4';
                    break;
                case '\"':
                    encrypted += '5';
                    break;
                case ')':
                    encrypted +=  "7";
                    break;
                case '?':
                    encrypted +=  "2";
                    break;
                case '!':
                    encrypted +=  "8";
                    break;
                case '-':
                    encrypted +=  "6";
                    break;
                case '%':
                    encrypted +=  "9";
                    break;
                case '1':
                    encrypted +=  "r";
                    break;
                case '2':
                    encrypted +=  "k";
                    break;
                case '3':
                    encrypted +=  "b";
                    break;
                case '4':
                    encrypted +=  "e";
                    break;
                case '5':
                    encrypted +=  "q";
                    break;
                case '6':
                    encrypted +=  "h";
                    break;
                case '7':
                    encrypted +=  "u";
                    break;
                case '8':
                    encrypted += "y";
                    break;
                case '9':
                    encrypted +=  "w";
                    break;
                case '0':
                    encrypted +=  "z";
                    break;
                default:
                    encrypted +=  "0";
                    break;
            }
        }
        return encrypted;
    }
    //check if username already exist or not
   public bool UserExist(string user)
    {
        if (username.Equals(user))
        {
            return true;
        }
        return false;
    }
    //return true if passwords match, it actually match both encrypted passwords,
   public bool Login(string pass)
    {
        string password = Encrypt(pass);
        if (cipher.Equals(password))
            return true;
        return false;
    }
}