# ユニラブ2024
ユニラブ2024の仕様説明などを書いていきます。
また、開発途中のメモのようなものもここに書こうと思います。

## 2024年5月11日（文責：S.N）
進捗
- [x] 土台となる部分の機能を実装
        - 詳細は「各ファイルの役割」を参照。
- [x] READMEの編集のやり方を少し身につけた

今後やりたいと思ったこと
- [ ] 最初に立ち上げるフォームは`Start.cs`にし、そこから`Prologue.cs`に飛んで、そこでストーリーの導入やキャラ選択などを行いたい。
- [ ] `Stage.cs`というフォームを作成し、ゲーム機能を実装する場所を作る。
- [ ] 迷路データを.csvファイルにして読み込んで表示する機能を実装する。
- [ ] 各ステージのクリア状況を管理する。

<!-- 以下、若干文法が複雑なので注意。基本的にはS.Nが書きます -->

## 各ファイルの役割
unilab2024は複数の`.cs`ファイルで構成されています。以下でそれぞれの役割について説明します。

機能が追加され次第追記していきます。

<details>

<summary>Program.cs</summary>

### Program.cs

`Program.cs`はこのプログラムの核となるファイルです。（現在は）2つのclassが用意されています。

#### internal static class Program
関数`Main()`が存在します。これはプログラムを実行したときに最初に実行される関数です。以下のコードで`Prologue`フォームを呼び出します。
```csharp
Application.Run(new Prologue());
```

#### public partial class Func
このプログラムで使用する関数は原則ここに書き留めることにしました。関数の役割ごとに`#region`環境でまとめます。以下はその例です。
極力この例に従い、何がどこにあるかわかるようにしてください。
```csharp
#region フォーム呼び出し
public static void CreateForm1(Form currentForm)
{
  //関数の定義
}

public static void CreateForm2(Form currentForm)
{
  //関数の定義
}
#endregion
```

なお、別のフォームから`Func`クラス内の関数を呼び出す際は次のように関数名の前に`Func.`を付けます。
```csharp
Func.CreateForm1(this);
```
</details>

<details>

<summary>Prologue.cs</summary>

### Prologue.cs

（現在は）このプログラムを実行したときに最初に呼び出されるフォームです。Start画面を表示します。現在はボタンをクリックすると`WorldMap.cs`を呼び出すようになっています。

</details>

<details>

<summary>WorldMap.cs</summary>

### WorldMap.cs

ワールド（学年）選択を行うフォームです。ボタンが複数配置されています。
各ボタンを押したときに`StageSelect.cs`のメンバ変数`WorldName`を指定して同フォームを立ち上げます。
ゆくゆくはクリア状況を管理し、ゲームを進めるごとに選択できるワールドを増やす仕様にしたいです。

</details>

<details>

<summary>StageSelect.cs</summary>

### StageSelect.cs

`WorldMap.cs`で何らかのワールド選択をすると立ち上がるフォームです。選択されたワールドによって表示内容を変えるため、classとしての**メンバ変数**を定義しています。
これは別フォームからの変更が効くようになっています。詳しくはコードを見てください。`各種メンバ変数の定義`に書いてあります。

このフォームからは`Stage.cs`、または`WorldMap.cs`に遷移することができます。

</details>

<details>

<summary>Stage.cs</summary>

### Stage.cs

このフォームにゲーム機能本体を実装します。

</details>
