# StoreUs
Sandėlio valdymo sistema, semestro projektas

Projektas buvo kurtas remiantis Agile principu. https://tree.taiga.io/project/kamnan-storeus/
Sukurta naudojant Windows Forms. Programą galima paleisti StoreUs\StoreUS\bin\Debug\StoreUs.exe, slaptažodis 123456

Pagrindinė idėja - sukurti sandėlio valdymo sistemą. Duomenų bazėje bus patalpintos kelios lentelės: sandėlyje esančios prekės (unikalus ID/barkodas, prekės pavadinimas, kilmės šalis/gamintojas, kiekis, kaina, statusas, pirkimo kaina (skaičiuoti realiam uždarbiui), gavimo data, pastabos), gauti užsakymai (unikalus užsakymo ID, data ir laikas, užsakovo pavadinimas, adresas, užsakyta prekė, užsakytos prekės kiekis, mokėtina suma, užsakymo statusas, pastabos), atlikti užsakymai (data, užsakymo ID, prekės ID, kiekis, kaina, pastabos). Sistema turi turėti 2 tipų prisijungimus - sandėlio darbuotojas ir pirkėjas. Vartotojo sąsajoje bus keli skirtukai (tabs), jog užtikrintų programos paprastumą jos vartotojams.
Prisijungęs sandėlio darbuotojas pirmame skirtuke gali matyti prekių sąrašą, atlikti prekės paiešką, redaguoti prekės kiekį, kainą, statusą ir pastabas. Antrame skirtuke pridėti naują prekę į sąrašą; teisingai užpildžius formą ir paspaudus mygtuką “pridėti”, bus parodyta informacinė lentelė, patvirtinanti sklandų įrašą. Trečiame skirtuke darbuotojas galės matyti gautų užsakymų sąrašą, atlikti užsakymo paiešką, redaguoti užsakymo statusą. Ketvirtame skirtuke darbuotojas matys atliktus užsakymus ir gautą uždarbį. 
Prisijungus prie sistemos pirkėjui, pirmame skirtuke jis matys prekių sąrašą (prekės pavadinimas, kilmės šalis, likęs kiekis, kaina), atlikti paiešką, pasirinkti prekes ir atlikti užsakymą. Antrame skirtuke bus profilio redagavimas (užsakovo pavadinimas, adresas). Trečiame skirtuke pirkėjas matys savo atliktus užsakymus. 

Bendradarbiai:
Nedas Kasparavičius,
Kamilė Nanartonytė,
Matas Senkus (tik pradinis karkasas, iš projekto po to pasitraukė)
