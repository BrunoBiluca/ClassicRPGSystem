public abstract class Creature {
    private int initialHealth;
    private int health;
    private int attack;
    private bool defenseState;

    // TODO: todos os atributos serão feitos por configuração de um arquivo em json, dessa forma fica mais fácil
    protected Creature(int initialHealth, int attack) {
        this.initialHealth = initialHealth;
        this.health = initialHealth;
        this.attack = attack;
        this.defenseState = false;
    }

    public int Health {
        get { return health; }
        set { health = value; }
    }

    public int Attack {
        get { return attack; }
        set { attack = value; }
    }

    public void TakeDamage(int amoutDamage) {

        // TODO: implementar um state pattern, visto que este método já depende se a criatura está ou não em estado de defesa
        if (defenseState) {
            health -= amoutDamage / 2;
            return;
        }

        health -= amoutDamage;
    }

    public void EnterIdleState() {
        defenseState = false;
    }

    public void EnterDefenseState() {
        defenseState = true;
    }

    public bool IsInDefenseState() {
        return defenseState;
    }
}