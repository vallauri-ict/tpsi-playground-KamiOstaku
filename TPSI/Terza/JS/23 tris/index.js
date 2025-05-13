let gameGrid = Array.from(Array(3),() => Array(3));
const gridDisplay = document.getElementsByTagName("table")[0];
const displayResult = document.getElementById("divRisultato");
let turno = 'x';
let cont = 0;

for(let i = 0; i < gameGrid.length;i++)
{
    let tr = document.createElement("tr");
    gridDisplay.appendChild(tr);
    for(let j = 0; j < gameGrid[i].length;j++)
    {
        let td = document.createElement("td");
        tr.appendChild(td);
        let image = document.createElement("img");
        td.appendChild(image);
        image.id = `img-${i}-${j}`;
        image.src = `img/vuota.png`;
        image.addEventListener("click", function pressione()
        {
            cont++;
            if(turno == 'x')
            {
                this.src = `img/croce.png`;
            }
            else
            {
                this.src = `img/cerchio.png`;
            }
            
            this.removeEventListener("click", pressione);

            if(cont == 9)
            {
                displayResult.textContent = "Pareggio";
            }
            else if(vittoria())
            {
                displayResult.textContent = `Ha vinto il giocatore con le ${turno}`;
            }
            turno = turno == 'x'? 'o' : 'x';
        });
    }
}

function vittoria()
{
    let prevImg;
    let supera = false;
    for(let i = 0; i < 3; i++)
    {
        for(let j = 1; j < 3; j++)
        {
            prevImg = document.getElementById(`img-${i}-${j-1}`).src;
            if(document.getElementById(`img-${i}-${j}`).src != prevImg)
            {
                supera = true;
                break;
            }
        }

        if(supera)
        {
            supera = false;
        }
        else
        {
            return true;
        }
    }
    return true;
    
}