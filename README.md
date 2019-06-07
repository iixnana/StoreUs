# StoreUs
Sandėlio valdymo sistema, semestro projektas

Projektas buvo kurtas remiantis Agile principu. https://tree.taiga.io/project/kamnan-storeus/
Sukurta naudojant Windows Forms. Programą galima paleisti StoreUs\StoreUS\bin\Debug\StoreUs.exe, slaptažodis 123456

Pagrindinė idėja - sukurti sandėlio valdymo sistemą. Duomenų bazėje bus patalpintos kelios lentelės: sandėlyje esančios prekės (unikalus ID/barkodas, prekės pavadinimas, kilmės šalis/gamintojas, kiekis, kaina, statusas, pirkimo kaina (skaičiuoti realiam uždarbiui), gavimo data, pastabos), gauti užsakymai (unikalus užsakymo ID, data ir laikas, užsakovo pavadinimas, adresas, užsakyta prekė, užsakytos prekės kiekis, mokėtina suma, užsakymo statusas, pastabos), atlikti užsakymai (data, užsakymo ID, prekės ID, kiekis, kaina, pastabos). Sistema turi turėti 2 tipų prisijungimus - sandėlio darbuotojas ir pirkėjas. Vartotojo sąsajoje bus keli skirtukai (tabs), jog užtikrintų programos paprastumą jos vartotojams.
Prisijungęs sandėlio darbuotojas pirmame skirtuke gali matyti prekių sąrašą, atlikti prekės paiešką, redaguoti prekės kiekį, kainą, statusą ir pastabas. Antrame skirtuke pridėti naują prekę į sąrašą; teisingai užpildžius formą ir paspaudus mygtuką “pridėti”, bus parodyta informacinė lentelė, patvirtinanti sklandų įrašą. Trečiame skirtuke darbuotojas galės matyti gautų užsakymų sąrašą, atlikti užsakymo paiešką, redaguoti užsakymo statusą. Ketvirtame skirtuke darbuotojas matys atliktus užsakymus ir gautą uždarbį. 
Prisijungus prie sistemos pirkėjui, pirmame skirtuke jis matys prekių sąrašą (prekės pavadinimas, kilmės šalis, likęs kiekis, kaina), atlikti paiešką, pasirinkti prekes ir atlikti užsakymą. Antrame skirtuke bus profilio redagavimas (užsakovo pavadinimas, adresas). Trečiame skirtuke pirkėjas matys savo atliktus užsakymus. 

Bendradarbiai:
Nedas Kasparavičius
Kamilė Nanartonytė
Matas Senkus (tik pradinis karkasas, iš projekto po to pasitraukė)

Vartotojo vadovas:
Bendra informacija: 
Paleidus programą reikia prisijungti: suvesti tinkamą slaptažodį į pateiktą laukelį ir paspausti mygtuką Submit. Suvedus teisingą slaptažodį, yra parodoma pagrindinis programos puslapis “Items”. Norint atsijungti nuo sistemos, galima paspausti mygtuką  Galima naviguoti tarp kitų puslapių, atitinkamai pasirenkant “New Order”, “Pending Orders” ar “Orders” puslapius.
Norint rikiuoti bet kurią duomenų lentelę reikia paspausti ant atitinkamos stulpelio antraštės.
Items puslapis: 
Galima atlikti paiešką “Search” zonoje, įvedant pageidaujamų laukų reikšmes ir spaudžiant mygtuką “Search”. Norint pamatyti pilną sąrašą, reikia spausti mygtuką “Clear”.
“Items” zonoje matomas visų prekių sutrumpintas sąrašas. Norint pamatyti konkrečios prekės detalesnę informaciją ar ją redaguoti, reikia spausti mygtuką “View/Edit”. Norint pridėti naują prekę į sąrašą, reikia užpildyti visus laukus išskyrus “Details” lauką ir spausti “Add” mygtuką. Jei laukai neužpildyti, prekė nebus pridėta. Užpildžius visus laukus atsidariusioje “Add Item” formoje, reikia spausti mygtuką “Add” norint išsaugoti prekę arba “Close” norint uždaryti formą neįrašant naujų duomenų.
New Order puslapis: 
Šiame puslapyje sudaromas naujas užsakymas.
Items zonoje pasirinkus prekę reikia pridėti į pirkinių krepšelį (zona Order) paspaudžiant atitinkamą “Add” mygtuką. Pridėta prekė bus patalpinta į pirkinių krepšelį su 1kg kiekiu. Norint redaguoti kiekį, reikia du kartus paspausti ant “Quantity” stulpelio laukelio ir įrašyti norimą kiekį klaviatūra ir paspausti Enter klavišą, kaina ir bendra kaina bus perskaičiuota. Nenorint pirkti prekės, į “Quantity” stulpelio laukelį nulį ir pridėjus užsakymą prekė nebus pridėta. Būtina užpildyti “Buyer Title” ir “Buyer Address” laukus. “Total Payment” lauke galima matyti bendrą užsakymo kainą, kurią turi sumokėti pirkėjas. Pridėjus norimas prekes ir užpildžius privalomus laukus, galima spausti mygtuką “Add Order” norint išsaugoti naują užsakymą, kuris bus pridėtas į “Pending Orders” puslapį. Nenorint išsaugoti naujo užsakymo, galima spausti mygtuką “Clear”.
Pending Orders puslapis: 
Galima atlikti paiešką “Search” zonoje, įvedant pageidaujamų laukų reikšmes ir spaudžiant mygtuką “Search”. Norint pamatyti pilną sąrašą, reikia spausti mygtuką “Clear”.
“Pending orders” zonoje matomas visų užsakymų sutrumpintas sąrašas. Norint pamatyti konkretaus užsakymo detalesnę informaciją ar ją redaguoti, reikia spausti mygtuką “View”.
Orders puslapis: 
“Orders” zonoje rodo atliktus užsakymus jų atlikimo tvarka. “Received payment” lauke galima matyti bendrą gautą užmokestį už užsakymus.
