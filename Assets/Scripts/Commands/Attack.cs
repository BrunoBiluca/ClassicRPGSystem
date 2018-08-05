public class Attack : ICommand {
    private readonly Creature attackCreature;
    private readonly Creature receiveCreature;

    public Attack(Creature attackCreature, Creature receiveCreate) {
        this.attackCreature = attackCreature;
        this.receiveCreature = receiveCreate;
    }

    public void Execute() {
        receiveCreature.TakeDamage(attackCreature.Attack);
    }

}
