"use strict"
const DIM = 4;
const wrapper = document.getElementById("wrapper");
let aus = [];

for (let i = 0; i < DIM; i++) {
    for (let j = 0; j < DIM; j++) {
        const div = document.createElement("div");
        wrapper.appendChild(div);
        div.classList.add("pedina");
        let n
        do {
            n = generaNumero(1, 17);
        } while (aus.includes(n))
        aus.push(n);
        if (n <= 15) 
        {
            div.style.backgroundColor = "blue";
            div.textContent = n;
        }
        div.id = `div-${i}-${j}`;
        
        div.addEventListener("click", function click()
        {
            let row = parseInt(this.id.split("-")[1]);
            let col = parseInt(this.id.split("-")[2]);

            
            if(row > 0)
            {
                let div = document.getElementById(`div-${row-1}-${col}`);

                if(div.textContent == "")
                {
                    swap(this,div);
                }
            }

            if(col > 0)
            {
                let div = document.getElementById(`div-${row}-${col-1}`);

                if(div.textContent == "")
                {
                    swap(this,div);
                }
            }

            if(col < DIM-1)
            {
                let div = document.getElementById(`div-${row}-${col+1}`);
                if(div.textContent == "")
                {
                    swap(this,div);
                }
            }

            if(row < DIM-1)
            {
                let div = document.getElementById(`div-${row+1}-${col}`);
                if(div.textContent == "")
                {
                    swap(this,div);
                }
            }

        });
    }
}

function controlloVittoria()
{
    let cont = 1;

    for(let i = 0; i < DIM; i++)
    {
        for(let j = 0; j < DIM; j++)
        {
            let div = document.getElementById(`div-${i}-${j}`);
            if(cont == div.textContent)
            {
                cont++;

                if(cont == 16)
                {
                    alert("Bravissimo hai vinto!!");
                    reset();
                    return;
                }
            }
            else
            {
                return;
            }
        }
    }
}

function reset()
{
    for(let i = 0; i < DIM; i++)
    {
        for(let j = 0; j < DIM; j++)
        {
            document.getElementById(`div-${i}-${j}`).removeEventListener("click",click());
        }
    }
}

function swap(cellaSelezionata,secondaCella)
{
    secondaCella.textContent = cellaSelezionata.textContent;
    secondaCella.style.backgroundColor = cellaSelezionata.style.backgroundColor;
    cellaSelezionata.textContent = "";
    cellaSelezionata.style.backgroundColor = "";
}

function generaNumero(min, max) {
    return Math.floor((max - min) * Math.random()) + min;
}