// Dieser Skript zeigt den Countdowntimer auf der Homepage.

// Zu erst muss das Zieldatum eingegeben werden. Format: "Mon TT, JJJJ HH:MM:SS".
var zielDatum = new Date("Jan 01, 2022 00:00:00").getTime();

// Der Timer soll jede Sekunde zählen/sich jede Sekunde updaten
var countdown = setInterval(function () {
    // Das aktuelle Datum wird nun errechnet
    var jetztDatum = new Date().getTime();
    // Die verbliebene Zeit wird nun errechnet als einfache Subtraktion
    var verbliebeneZeit = zielDatum - jetztDatum;

    // Nun findet die eigentliche Konversion statt, so dass die verbliebene Tage, Stunden, Minuten und Sekunden angezeigt werden können.
    var tage = Math.floor(verbliebeneZeit / (1000 * 60 * 60 * 24));
    var stunden = Math.floor(verbliebeneZeit % (1000 * 60 * 60 * 24) / (1000 * 60 * 60));
    var minuten = Math.floor(verbliebeneZeit % (1000 * 60 * 60) / (1000 * 60));
    var sekunden = Math.floor(verbliebeneZeit % (1000 * 60) / 1000);

    // Die Ergebnisse nach der Konversion werden nun in das HTML-Dokument eingespeist
    document.getElementById("countdown-info").innerHTML = "Die TCH findet am [hier Datum eingeben] statt."
    document.getElementById("countdown-tage").innerHTML = tage + ":"
    document.getElementById("countdown-stunden").innerHTML = stunden + ":"
    document.getElementById("countdown-minuten").innerHTML = minuten + ":"
    document.getElementById("countdown-sekunden").innerHTML = sekunden

    // Falls das Zieldatum in der Vergangenheit liegt, wird eine Nachricht angezeigt
    if (verbliebeneZeit < 0) {
        // Damit der Skript dann auch aufhört jede Sekunde Sachen zu berechnen
        clearInterval(countdown);
        document.getElementById("countdown-info").innerHTML = "Die TCH fand am [hier Datum eingeben] statt."
        document.getElementById("countdown-tage").innerHTML = ""
        document.getElementById("countdown-stunden").innerHTML = ""
        document.getElementById("countdown-minuten").innerHTML = ""
        document.getElementById("countdown-sekunden").innerHTML = ""
        document.getElementById("countdown-ende").innerHTML = "Wir freuen uns nächstes Jahr auf Dich!"
    }

}, 1000);