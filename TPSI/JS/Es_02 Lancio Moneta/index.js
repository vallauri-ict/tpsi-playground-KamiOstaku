'use strict'

function NumberGenerator(min,max)
{
    //Genera un numero casuale tra min e max(escluso)
    let number = Math.floor((max-min)*Math.random() + min);
    return number;
}

function lanciaMoneta()
{
    let counter = document.getElementById("txtLanci").value;
    let croce = 0, testa = 0;
    for(let i = 0; i < counter; i++)
    {
        if(NumberGenerator(0,2) == 0)
        {
            croce++;
        }
        else
        {
            testa++;
        }
    }
    
}
