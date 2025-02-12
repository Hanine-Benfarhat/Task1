
using Task1.GenericsOverrideVirtual;

Stock<string> stockProduits = new Stock<string>();
stockProduits.Ajouter("Ordinateur");
stockProduits.Ajouter("Souris");
stockProduits.AfficherTous();

Stock<int> stockNombres = new Stock<int>();
stockNombres.Ajouter(42);
stockNombres.Ajouter(100);
stockNombres.AfficherTous();

Stock<Client> StockClient = new Stock<Client>();
var client1 = new ClientVIP() { Nom = "Rim" };
client1.AfficherClient();
var client2 = new Client() { Nom = "Ahmed" };
client2.AfficherClient();
StockClient.Ajouter(client1);
StockClient.Ajouter(client2);
StockClient.AfficherTous();
StockClient.Supprimer(client2);