

Pour utiliser « async » et « await » d’une manière appropriée, il faut que le type de retour
 des fonctions asynchrones marquées par le mot clé « async » soit :

 - void

 - Task

 - Task<T> ou T est un type générique qui représente le type de retour



Lors de la conversion d’une méthode synchrone en asynchrone

 - Toute méthode retournant un type T, doit devenir une méthode retournant un type Task<T>

 - Toute méthode retournant « void », doit devenir une méthode retournant un type Task



Il est facile de commencer plusieurs méthodes asynchrones void , mais il est difficile de déterminer quand elles finissent. 

Pour le cas des méthodes Task , il est possible de gérer ce côté via l’appel de la méthode WhenAll(Ienumerable<Task>)

Il faut garder à l’esprit d’utiliser les méthodes void seulement en cas de gestion des événements asynchrones 