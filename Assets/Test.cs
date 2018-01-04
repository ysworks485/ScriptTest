using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
    private int hp = 100; // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; // マジックポイント

    // 攻撃用の関数
    public void Attack() {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage) {
        Debug.Log(damage + "のダメージを受けた");
        // 残りのhpを減らす
        this.hp -= damage;
    }

    // 魔法用の関数
    public void Magic()
    {
        if (this.mp >= 5) {
            // 残りのmpを減らす
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else {
            // 残りのmpが不足している
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

}

public class Test : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        ///////////////////////////////////////////////////////
        // 課題：配列を宣言して出力
        ///////////////////////////////////////////////////////

        // 要素数5のint型の配列arrayを初期化する
        int[] array = { 5, 15, 25, 35, 45 };

        // 配列の要素を順番に表示する
        for (int i = 0; i < array.Length; i++) {
            Debug.Log(array[i]);
        }

        // 配列の要素を逆順に表示する
        for (int i = array.Length - 1; i >= 0; i--) {
            Debug.Log(array[i]);
        }

        ///////////////////////////////////////////////////////
        // 発展課題：Bossクラスに変数mpとMagic関数を作成
        ///////////////////////////////////////////////////////

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        // 魔法用の関数を呼び出す
        for (int i = 0; i <= 10; i++) {
            // mp初期値=53 ⇒ 1～10回目はOK、11回目はNG
            lastboss.Magic();
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
