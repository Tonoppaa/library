# Kuvaus

Tämä on kirjasto-ohjelma, jossa on kaksi osapuolta: Asiakas ja henkilökunta. Asiakkaalla ja henkilökunnan jäsenellä on mahdollista kirjautua kirjaston järjestelmään henkilökohtaisella käyttäjätunnuksella ja salasanalla. Ominaisuuksissa on tarkemmin eriteltynä, mitä asiakas tai henkilökunta voivat tehdä.

# Edellytykset

Tässä projektissa tarvitaan seuraavia asioita:

- GitHub
- MySQL
- Visual Studio (huomaa, että Visual Studiossa täytyy asentaa erillinen NuGet-paketti, jotta MySQL-tietokannan saa toimimaan. Se löytyy NuGet Package Managerin kautta ja kun haetaan pakettia nimeltä "MySQL.Data". Tämän paketin asentamisen jälkeen MySQL toimii tässä projektissa!

Projektin tietokanta on luotu MySQL:ssä. Ohjelman saa yhdistettyä tietokantaan luomalla uusi paikallinen tietokanta.
Oleellista on, että seuraavat parametrit ovat määritetty palvelinyhteyksiin (Server Connection):

	- Hostname: localhost
	- Port: 3306
	- Username: root

Tietokantaan saadaan dataa ajamalla "CREATE_INSERT-sentences.txt":n sisältö ("CREATE" ja "INSERT INTO"-lauseet) tietokantaan.

# Ominaisuudet (asiakas)

Asiakkaalla on mm. seuraavia toimintoja/sivuja:

- Etusivu (voidaan mm. nähdä lainattujen kirjojen lukumäärä)
- Aineistot (voidaan tarkastella kirjaston aineistoa eli kirjoja kategorioittain)
- Omat lainat (voidaan tarkastella lainattuja kirjoja)
- Omat tiedot (voidaan tarkastella henkilökohtaisia tietoja ja tarpeen mukaan niitä voidaan muuttaa, myös salasanan
vaihtaminen on mahdollista)
- Hakukenttä (voidaan hakea kirjaston tietokannassa olevia kirjoja ja tehdä lainaus)

# Ominaisuudet (henkilökunta)

Henkilökunnalla on mm. seuraavia toimintoja/sivuja:

- Etusivu
- Aineistot (voidaan tarkastella kirjaston aineistoa eli kirjoja kategorioittain. Kirjoja voidaan muokata)
- Tarkka haku (voidaan hakea kirjaston kirjoja useilla eri vaihtoehdolla, esim. Kirjan nimellä, kategorialla ym. Tarkan
haun kautta voidaan hakea myös asiakkaita)
- Oma sivu (voidaan tarkastella omia tietoja ja muuttaa oman käyttäjätunnuksen salasanaa)
- Lisää järjestelmään (voidaan lisätä tietokantaan kirjoja tai asiakkaita)

