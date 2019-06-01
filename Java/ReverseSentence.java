package test;

/**
 *
 * @author harold-mc
 */
public class Test {

    public static void main(String[] args) {
        
        char[] word = {'H', 'o', 'y', ' ' ,'e', 's', ' ','v','i','e', 'r', 'n','e','s'};
        char[] word2 = {'H', 'a', 'r', 'o' ,'l', 'd', ' ','c','o','r', 'd', 'e','r','o'};
        char[] word3 = {'O', 'r', 'i', 'o' ,'n', ' ', 'T','e','k'};
       
        System.out.println(getReverse(word3));
        
        
    }
    
    public static String getReverse(char[] list){
        
        String word = ""; 
        String paragraph = ""; // Oracion a devolver
        
        for(int i = list.length - 1; i >= 0; i--){
            
            word += list[i];
            
            if((list[i] == ' ' && list[i + 1] != ' ') || i == 0){
                
                String reverse = "";
                
                for(int j = word.length()-1; j >= 0; j--){
                    reverse += word.charAt(j);
                }
                
                paragraph += reverse.trim() + " ";
                word = "";
            }
            
        }
            return paragraph;
    }
    
}