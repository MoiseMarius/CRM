Aplicatia este un windows form conectat la o baza de date SQL
Aceasta aplicatie se poate folosi in corporatii pentru ca fiecare utilizator sa isi monitorizeze performanta
Flow-ul aplicatiei este: 
1. Utilizatorul se inregistreaza o singura data
2. Utilizatorul se autentifica
3. Utilizatorul isi introduce activitatile si punctajul lor
4. Utilizatorul se uita in clasament si incearca sa isi mareasca constant performanta
4'. Utilizatorul foloseste pagina de contact sa ia legatura cu cei de deasupra lui in clasament sa invete de la ei
4''. Utizatorul participa la mai multe tipuri de activitati in functie de tipul (id-ul) categoriei

Tehnologii, tool-uri si resurse folosite:
1. SQL Database
2. SQL Database Project
3. Windows Forms - NET Framework
4. Entity Framework
5. LINQ
6. Connexiuni de date
7. Extensii pentru salvarea datelor

1. Procedurile stocate folosite sunt: Autentificare, care ne spune sau nu daca datele de login sunt corecte, 
si InsereazaActivitate care insereaza o activitate in baza de date
2. Tranzactia este chiar InsereazaActivitate
3. Avem 2 VIEW-uri: Clasament care face top 3/ activitate si InformatiiComplete care uneste Person si Contact
4. Tratam exceptiile prin try/catch si in puncte critice inchidem programul. La erori standard doar invalidam.
5. Raportul se poate exporta, momentan, in excel
6. this
7. Parola este hash-utita de functiile de baza;