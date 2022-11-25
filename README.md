<h1>EasySave1.0</h1>

Vous trouverez ici les informations importantes concernant le fonctionnemennt du logiciel.

<h2>I | Diagramme UML</h2>

Vous pouvez retrouver ci-dessous l'ensemble des diagrammes UML que nous avons créés pour aider à la compréhension de l’application, de ses fonctionnalités et de son architecture. Pour cela 3 différents types de diagrammes ont été réalisés :

- un diagramme d'activité centré sur l'utilisation des fonctionnalités le l’application de manière globale.
- 4 diagrammes de séquences centrés, sur l'utilisation de chaque fonctionnalités.
- un diagramme de classes pour mettre en place l'architecture de notre code.

<h3>A. Diagramme d'activité</h3>

Le diagramme d’activité nous permet de visualiser et de modéliser le comportement interne de notre système lors d'un cas d'utilisation ou d'un processus.

Ci-dessous vous pouvez voir le diagramme d'activité complet de notre application :

<img src="https://www.notion.so/image/https%3A%2F%2Fs3-us-west-2.amazonaws.com%2Fsecure.notion-static.com%2F59f5b09c-f411-4ab7-9665-f498c1ca1269%2FUntitled.png?table=block&id=7307688e-e4c1-4620-badb-e2c4df9fb9ff&spaceId=fb565f9f-9b70-4a86-88e9-ffa8e7bb3756&width=2000&userId=a01ff20c-cd8d-4655-8041-f08b17481938&cache=v2" title="da">

<h3>B. Diagramme de séquence</h3>

Le diagramme de séquences permet de montrer les différentes interactions entre les acteurs et le système selon un ordre chronologique. Nous avons réalisé les 4 suivants.   

Ci-dessous, au premier lancement du programme, l’utilisateur va pouvoir choisir la langue d’utilisation entre anglais et français. De plus, le système détectera si il s’agit du premier lancement afin de créer un dossier par défaut.

<img src="https://www.notion.so/image/https%3A%2F%2Fs3-us-west-2.amazonaws.com%2Fsecure.notion-static.com%2F489afd84-ac9a-47c5-bee2-bb2b728104be%2Fconsole_diagram.png?table=block&id=12caf084-1a73-497a-9239-fef559e014b1&spaceId=fb565f9f-9b70-4a86-88e9-ffa8e7bb3756&width=2000&userId=a01ff20c-cd8d-4655-8041-f08b17481938&cache=v2" title="ds1">

Ce second diagramme représente les changements dans configuration que l’utilisateur va pouvoir effectuer comme changer la langue ou désinstaller le programme.

<img src="https://s3.us-west-2.amazonaws.com/secure.notion-static.com/2a5d4784-523c-479d-8599-cd0140ce3bdf/configuration_diagram.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20221125%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20221125T171249Z&X-Amz-Expires=86400&X-Amz-Signature=b8dcdc9677073cfcf19702874d429af47abea456bf7a9f3c7186e023425e344b&X-Amz-SignedHeaders=host&response-content-disposition=filename%3D%22configuration%2520diagram.png%22&x-id=GetObject" title="ds2">

Le diagramme suivant montre la création d’un travail de sauvegarde.

<img src="https://s3.us-west-2.amazonaws.com/secure.notion-static.com/cce845f1-7ed8-45cd-a90d-5cbdddacc253/create_diagram.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20221125%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20221125T171309Z&X-Amz-Expires=86400&X-Amz-Signature=fb7e5fedc2dc5a0d6725833a522716858d8a4502108901378fdfac35d22fe699&X-Amz-SignedHeaders=host&response-content-disposition=filename%3D%22create%2520diagram.png%22&x-id=GetObject" title="ds3">

Ce dernier diagramme montre les interactions lorsque l’utilisateur veut consulter les fichiers sauvegardés précédemment, ainsi que de déplacer une sauvegarde vers un dossier cible.

<img src="https://s3.us-west-2.amazonaws.com/secure.notion-static.com/c56befd5-5ad3-4ca9-a56f-de9b6e1abab4/consult_diagram.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20221125%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20221125T171323Z&X-Amz-Expires=86400&X-Amz-Signature=e40d9b70ebac4f3e814a72d3e3c0eeabcd875241db88f0112cf4f5d775c36c65&X-Amz-SignedHeaders=host&response-content-disposition=filename%3D%22consult%2520diagram.png%22&x-id=GetObject" title="ds4">

<h3>C. Diagramme de classe</h3>

Le diagramme de classes nous permet de construire l'architecture de notre programme. Il liste par classe les différents attributs et méthodes qui lui correspondent.

<img src="https://s3.us-west-2.amazonaws.com/secure.notion-static.com/0c4ead9f-047f-4c57-b6cb-9b875148b55a/diagramme_de_classes.drawio.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Content-Sha256=UNSIGNED-PAYLOAD&X-Amz-Credential=AKIAT73L2G45EIPT3X45%2F20221125%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20221125T171332Z&X-Amz-Expires=86400&X-Amz-Signature=da52da40eaae4fba6453753c84e87b8d75147f1b40fb6d8b4e6a4ef42f490a0b&X-Amz-SignedHeaders=host&response-content-disposition=filename%3D%22diagramme_de_classes.drawio.png%22&x-id=GetObject" title="dc">

<h2>II | Documentation</h2>
