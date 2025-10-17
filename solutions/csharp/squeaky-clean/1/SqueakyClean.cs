public static class Identifier
{
    public static string Clean(string identifier)
    {
        if (identifier.Contains(" ")){
                identifier = identifier.Replace(" ","_");
        }

        if (identifier.Contains("-")){
            char bar = '-';
            char letter = identifier[identifier.IndexOf(bar)+1];
            identifier = identifier.Replace($"-{letter.ToString()}",Char.ToUpper(letter).ToString());
        }
        if (1==1){
            
            foreach (char a in identifier){
                var greekwords= identifier.Where(c => c >= '\u03B1' && c <= '\u03C9');;
                if (Char.IsControl(a)) {
                    identifier = identifier.Replace(a.ToString(),"CTRL");
                    
                }
                if (!(Char.IsLetter(a)) && a!='_'){
                    identifier = identifier.Replace(a.ToString(),"");
                }
                if(1==1){
                    foreach (var c in greekwords)
                    {
                        identifier = identifier.Replace(c.ToString(),"");
                    }
                    
                }
                
            }
        }
        return identifier;

        
    }
}
