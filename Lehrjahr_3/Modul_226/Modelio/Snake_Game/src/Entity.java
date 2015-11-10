import com.modeliosoft.modelio.javadesigner.annotations.objid;

@objid ("e4bbac8c-b3a1-400d-9f6e-32bbe2692b98")
public abstract class Entity {
    @objid ("09c5b639-e656-4888-8b33-595479eb4edf")
    protected boolean isAlive;

    @objid ("1ebc5291-6873-4ef2-b9cc-ec8d78e8a491")
    protected int x;

    @objid ("94a1f3c0-6b49-4045-ad08-c163680cf4f6")
    protected int y;

    @objid ("e99df0a9-9008-474a-9865-96a7ac13a00d")
    public void Entity() {
    }

    @objid ("e8396dd0-39bb-4d86-8f40-f5dc7b44fa0b")
    public abstract void draw();

    @objid ("5eab741e-9d08-4700-bb67-ba3f66510c0c")
    int getX() {
        // Automatically generated method. Please delete this comment before entering specific code.
        return this.x;
    }

    @objid ("881f3599-63b2-43ac-bd51-bfeba219b789")
    void setX(int value) {
        // Automatically generated method. Please delete this comment before entering specific code.
        this.x = value;
    }

    @objid ("85221ab6-98af-4cc7-8960-6b6b05a529fc")
    int getY() {
        // Automatically generated method. Please delete this comment before entering specific code.
        return this.y;
    }

    @objid ("4c03ecd3-b17f-4c57-9552-1f405fbc7a08")
    void setY(int value) {
        // Automatically generated method. Please delete this comment before entering specific code.
        this.y = value;
    }

}
