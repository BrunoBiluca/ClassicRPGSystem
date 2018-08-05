public class Defense : ICommand {

    private Creature defensiveCreature;

    public Defense(Creature defensiveCreature) {
        this.defensiveCreature = defensiveCreature;
    }

    public void Execute() {
        defensiveCreature.EnterDefenseState();
    }
}
