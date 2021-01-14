using System;

class ForAnidado{
    static void Main (string [] args){
        for (int i=0; i<50;i++){
            for (int j=0; j<10; j++){
                if (i+j == 50) break;
            }
        }
    }
}