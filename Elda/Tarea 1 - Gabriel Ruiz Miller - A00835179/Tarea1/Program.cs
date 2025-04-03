// Stack para acciones del jugador (deshacer)
class ActionStack
{
    private Stack<string> stack = new Stack<string>();

    public void PushAction(string action)
    {
        stack.Push(action);
    }

    public string PopAction()
    {
        return stack.Count == 0 ? "No hay acciones para deshacer" : stack.Pop();
    }

    public string PeekAction()
    {
        return stack.Count == 0 ? "No hay acciones" : stack.Peek();
    }

    public bool IsEmpty()
    {
        return stack.Count == 0;
    }
}

// Queue para enemigos en cola
class EnemyQueue
{
    private Queue<string> queue = new Queue<string>();

    public void EnqueueEnemy(string enemy)
    {
        queue.Enqueue(enemy);
    }

    public string DequeueEnemy()
    {
        return queue.Count == 0 ? "No hay enemigos en la cola" : queue.Dequeue();
    }

    public string PeekEnemy()
    {
        return queue.Count == 0 ? "No hay enemigos" : queue.Peek();
    }

    public bool IsEmpty()
    {
        return queue.Count == 0;
    }
}

// Diccionario para puntajes de jugadores
class ScoreTable
{
    private Dictionary<string, int> scores = new Dictionary<string, int>();

    public void AddScore(string player, int score)
    {
        scores[player] = score;
    }

    public int GetScore(string player)
    {
        return scores.ContainsKey(player) ? scores[player] : 0;
    }

    public void RemovePlayer(string player)
    {
        scores.Remove(player);
    }

    public bool HasPlayer(string player)
    {
        return scores.ContainsKey(player);
    }
}

class GameDataStructuresTest
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Tarea 1 ---");
        Console.WriteLine("Gabriel Ruiz Miller");
        Console.WriteLine("#A00835179");


        Console.WriteLine("\n--- Stack de Acciones del Jugador ---");
        ActionStack actionStack = new ActionStack();
        actionStack.PushAction("Mover adelante");
        actionStack.PushAction("Recoger arma");
        actionStack.PushAction("Disparar");
        Console.WriteLine("Última acción: " + actionStack.PeekAction());
        Console.WriteLine("Deshaciendo acción: " + actionStack.PopAction());

        Console.WriteLine("\n--- Cola de Enemigos ---");
        EnemyQueue enemyQueue = new EnemyQueue();
        enemyQueue.EnqueueEnemy("Orco");
        enemyQueue.EnqueueEnemy("Goblin");
        enemyQueue.EnqueueEnemy("Dragón");
        Console.WriteLine("Siguiente enemigo: " + enemyQueue.PeekEnemy());
        Console.WriteLine("Eliminado de la cola: " + enemyQueue.DequeueEnemy());

        Console.WriteLine("\n--- Tabla de Puntuaciones ---");
        ScoreTable scoreTable = new ScoreTable();
        scoreTable.AddScore("Gabriel", 1500);
        scoreTable.AddScore("Vale", 2200);
        Console.WriteLine("Puntuación de Gabriel: " + scoreTable.GetScore("Gabriel"));
        Console.WriteLine("Vale está en la tabla: " + scoreTable.HasPlayer("Vale"));
        scoreTable.RemovePlayer("Gabriel");
        Console.WriteLine("Gabriel está en la tabla: " + scoreTable.HasPlayer("Gabriel"));
    }
}