hvad jeg fandt ud af ved og følge tutorialen punkt til punkt(matcher bortset fra nogle få kommentare og switch i program til styring)

Sockets har 2 modes, lytter og forbundet. 
når du opretter en socket og indstiller den til at lytte på en bestemt port, venter den i princippet på indgående forbindelser, på samme måde som en lytter arbejder. 
Når en forbindelse accepteres, oprettes der en ny socket (Kaldet clientsocket) til at håndtere kommunikationen med den pågældende klient.

hvis den fil der bliver requested finder den det eller sender fejl kode 404 for not found, (fil skal ligge i en mappe for den kan finde dem)

http requests

delt i 3 blokke

The method, target and the http version                              
Get /order/123 HTTP/1.1                                                  
                                                                     
Headers                                                                                     
Host: 127.0.0.1:8080 // ip og port                                                          
User-Agent: Mozilla/5.0 // browser type og version                                          
 
Body
get har ikke en body, men post har order_id=156
                                                          
Get /order/123 HTTP/1.1
Host: 127.0.0.1:8080
User-Agent: Mozilla/5.0

Post /orders http/1.1
Host: 127.0.0.1:8080
User-Agent: Mozilla/5.0
Content lenth 12
Content-Type: application/x-www-form-urlencoded
order_id=156
