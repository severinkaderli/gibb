package ch.severinkaderli.snake;

public abstract class Entity {
    protected boolean isAlive;

    protected int x;

    protected int y;

    public void Entity() {
    }

    public abstract void draw();

    int getX() {
        return this.x;
    }

    void setX(int value) {
        this.x = value;
    }

    int getY() {
        return this.y;
    }

    void setY(int value) {
        this.y = value;
    }

}
