const DIM = 10;
let livello = -1;

let wrapper = document.getElementById("wrapper");

createMatrix();

let timerId = setInterval(visualizza, 500);

function visualizza()
{
    console.log(livello);
    reset();
    if(livello == 4)
    {
        livello = 0;
    }
    else 
    {
        livello++;
    }
    disegnaLivello(livello)

}

function disegnaLivello(livello)
{
    for(let n = livello; n < DIM-livello; n++)
    {
        //disegna prima colonna
        let div = document.getElementById(`div-${n}-${livello}`)    
        div.style.backgroundColor = "red";
        div.dataset.colore = "rosso";
        
        //disegna prima riga
        div = document.getElementById(`div-${livello}-${n}`)    
        div.style.backgroundColor = "red";
        div.dataset.colore = "rosso";

        //disegna ultima colonna
        div = document.getElementById(`div-${n}-${DIM-livello-1}`)    
        div.style.backgroundColor = "red";
        div.dataset.colore = "rosso";
        
        //disegna ultima riga
        div = document.getElementById(`div-${DIM-livello-1}-${n}`)    
        div.style.backgroundColor = "red";
        div.dataset.colore = "rosso";

    }

}

function reset()
{
    //a tutti i tag div di colore rosso assegneremo un attributo HTML colore = rosso cosi possiamo accederci tramite querySelectorAll;
    // il prefisso data viene aggiunto automaticamente davanti all'attirubuto statico
    //dentro querySelectorAll l'attributo personale deve essere utilizzato come attributo statico
    let divs = document.querySelectorAll("div[data-colore=rosso]");
    for(let div of divs )
    {
        div.style.backgroundColor = "";
        div.dataset.colore = "grigio";
        console.log("done")
    }
}

function createMatrix()
{
    for(let i = 0; i < DIM; i++)
    {
        for(let j = 0; j < DIM; j++)
        {
            let div = document.createElement("div");
            div.classList.add("cella");
            div.id = `div-${i}-${j}`;
            wrapper.appendChild(div);
        }
    }
}

function generaNumero(min, max){
    let rnd = Math.floor((max - min) * Math.random()) + min;   
    return rnd;
}






















