package contarctImpl.State;

/**
 * @Author zyh
 * @Date 2022/6/19 7:16 下午
 * @Version 1.0
 */
public class StateDemo {
    private String id;
    private String hash;

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getHash() {
        return hash;
    }

    public void setHash(String hash) {
        this.hash = hash;
    }

    @Override
    public String toString() {
        return "StateDemo{" +
                "id='" + id + '\'' +
                ", hash='" + hash + '\'' +
                '}';
    }
}
