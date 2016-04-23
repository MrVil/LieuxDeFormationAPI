# LieuxDeFormationAPI

L'API est écrit en ASP.NET CORE, généré avec yo (https://github.com/OmniSharp/generator-aspnet)[aspnet] 

Vous avez besoin d'installer (https://get.asp.net/)[ASP.NET] et (https://nodejs.org)[Node.js]

Ensuite, installez yeoman et le generateur aspnet.
```
npm i -g yo generator-aspnet
```

Pour installer les dépendances :
```
dnu restore
```

Pour lancer le projet :
```
dnx web
```

Pour créer un nouveau controller :
```
yo aspnet:WebApiContoller <name>
```
