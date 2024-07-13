# ユニラブ2024
ユニラブ2024の仕様説明などを書いていきます。
また、開発途中のメモのようなものもここに書こうと思います。

## 進捗日記

### 2024年7月13日（文責：S.N）
<details>
        
進捗
- [ ] 今週は試験があるので一旦休止

今後やること
- [ ] 文字サイズ大きくする
- [ ] 細かいところを詰めていく

</details>

### 2024年7月6日（文責：S.N）
<details>
        
進捗
- [x] キャラ選択機能実装した
- [x] play後のストーリー表示機能も実装した
- [x] Clear済みのボタンにはClear!、新しく出現したステージのボタンにはNew!と表示されるようにした。
- [x] Prologueから直接1-1開くようにした

今後やること
- [ ] 文字サイズ大きくする
- [ ] 細かいところを詰めていく

</details>

### 2024年6月29日（文責：S.N）
<details>
        
進捗
- [x] 先週の画像読み込めない問題は拡張子を勝手に変えてたことが原因だった．適切に変換を施したファイルを使用したら普通に読み込めた．
- [x] 進行状況管理を実装した．
- [x] WorldMapで`m`キーを押すと全てクリア済みになるようにした．
- [x] StageSelectで`m`キーを押すとそのWorldの3ステージのみ全部クリアになるようにした．
- [x] play前のストーリー表示機能を実装した（play後はこれから）．

今後やること
- [ ] 文字サイズ大きくする
- [ ] キャラ選択機能を実装したい

</details>

### 2024年6月22日（文責：S.N）
<details>
        
進捗
- [x] `Stage.cs`のUI更新
- [ ] なぜかImg_Background_AnotherWorld.pngを読み込もうとすると「メモリ不足」というエラーが出る。サイズ自体は500KB程度なので何かがおかしい。
- [ ] 今週はあまり進められなかった。

今後やること
- [ ] 文字サイズ大きくする
- [ ] クリア状況に応じて押せるボタンと押せないボタンを分ける
- [ ] デザイン等引き続き。
- [ ] キャラ選択機能を実装したい

</details>

### 2024年6月15日（文責：S.N）
<details>
        
進捗
- [x] `Stage.cs`のUI更新
- [x] CustomButtonでButtonの文字の上に画像表示できるようにした
- [x] `Shift`+`m`でクリアチェックショートカットできるようにした 

今後やること
- [ ] 文字サイズ大きくする
- [ ] クリア状況に応じて押せるボタンと押せないボタンを分ける
- [ ] デザイン等引き続き。
- [ ] キャラ選択機能を実装したい

</details>

### 2024年6月8日（文責：S.N）
<details>
        
進捗
- [x] `Stage.cs`がエラーなしで立ち上がるようにした（動作はまだしない）
- [x] 中間発表done

今後やること
- [ ] 文字サイズ大きくする
- [ ] クリア状況に応じて押せるボタンと押せないボタンを分ける
- [ ] デザイン等引き続き。
- [ ] 迷路データを.csvファイルにして読み込んで表示する機能を実装する。
- [ ] キャラ選択機能を実装したい

</details>

### 2024年6月1日（文責：S.N）
<details>
        
進捗
- [x] 63のPCルームでの動作確認をした
- [x] フォームの縦横サイズは1536*900で作る 
- [x] デザインを少しいじった
- [x] stage作成の際は`WorldName`, `WorldNumber`, `Level`を指定するようにした
- [x] `Progress`クラスを作成し、そのメンバ変数として`IsCleared`配列を作成。これでクリアチェックできるようにした
- [x] その他細かい部分をいくつか修正

今後やること
- [ ] クリア状況に応じて押せるボタンと押せないボタンを分ける
- [ ] とりあえず`Stage`動くようにしたい
- [ ] デザイン等引き続き。
- [ ] 迷路データを.csvファイルにして読み込んで表示する機能を実装する。
- [ ] キャラ選択機能を実装したい

</details>

### 2024年5月25日（文責：S.N）
<details>
        
進捗
- [x] binやobjフォルダもプル/プッシュできるようにした
- [x] `Image`変数を宣言しなくてもよいようにDictionaryを作成した
- [x] 関が`Stage.cs`をたくさん編集。

今後やること
- [ ] クリア状況の管理をする
- [ ] デザイン等引き続き。
- [ ] 迷路データを.csvファイルにして読み込んで表示する機能を実装する。
- [ ] キャラ選択機能を実装したい

</details>

### 2024年5月18日（文責：S.N）
<details>
        
進捗
- [x] 最初に立ち上げるフォームを`Title.cs`とし、「はじめる」ボタンを押すと`Prologue.cs`が起動されるようにした。
- [x] `Prologue.cs`で会話が表示されるようにした。
- [x] 関が`Stage.cs`をたくさん編集。

今後やること
- [ ] `Stage.cs`にもメッセージ表示用の環境を作る。
- [ ] デザイン等も引き続き。
- [ ] 迷路データを.csvファイルにして読み込んで表示する機能を実装する。
- [ ] 各ステージのクリア状況を管理する。

</details>

### 2024年5月11日（文責：S.N）
<details>
        
進捗
- [x] 土台となる部分の機能を実装
        - 詳細は「各ファイルの役割」を参照。
- [x] READMEの編集のやり方を少し身につけた

今後やりたいと思ったこと
- [ ] 最初に立ち上げるフォームは`Start.cs`にし、そこから`Prologue.cs`に飛んで、そこでストーリーの導入やキャラ選択などを行いたい。
- [ ] `Stage.cs`というフォームを作成し、ゲーム機能を実装する場所を作る。
- [ ] 迷路データを.csvファイルにして読み込んで表示する機能を実装する。
- [ ] 各ステージのクリア状況を管理する。

</details>

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

<summary>Title.cs</summary>

### Title.cs

このプログラムを実行して最初に立ち上がるフォームです。このフォームを閉じるとプログラムが終了してしまうので注意します。

「はじめる」ボタンが設置されており、これを押すと`Prologue.cs`が起動します。

</details>

<details>

<summary>Prologue.cs</summary>

### Prologue.cs

`Title.cs`の次に呼び出されるフォームです。ストーリーのプロローグを表示します。現在はボタンをクリックすると`WorldMap.cs`を呼び出すようになっています。

開発が進んできたらここでキャラ選択を行う予定です。

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
これは別フォームからの変更が効くようになっています。例えば次のような感じです.
```csharp
public class StageSelect : Form
{
        #region 各種メンバ変数の定義
        private string _worldName;  //WorldMapで選択された学年
        
        public string WorldName     //こう書くと別フォームからアクセスできるっぽい。原理はよくわからん
        {
            get { return _worldName; }
            set { _worldName = value; }
            //別フォームからのアクセス例
            //StageSelect form = new StageSelect();
            //form.WorldName = "学年";
        }
        #endregion
}
```

このフォームからは`Stage.cs`、または`WorldMap.cs`に遷移することができます。

</details>

<details>

<summary>Stage.cs</summary>

### Stage.cs

`StageSelect.cs`でステージを選択することで立ち上がるフォームです。選択したステージごとに描画を変更するため、classとしての**メンバ変数**を定義しています。
またボタンなどのコントロール毎に動作を定義しています。例えば次のような感じです。
```csharp
public static void ResetListBox(ListBox listbox)   //ListBoxの中身消去
{
        if (listbox.SelectedIndex > -1)
        {
                listbox.Items.RemoveAt(listbox.SelectedIndex);
        }
        else
        {
                listbox.Items.Clear();
        }
}
```
またキャラクターの動作をボタン入力によって実装し、ユーザからの入力を変換することでMap上で動きとして表現してあります。
衝突検知は`colision_detection`という関数で実装してあります。
また会話機能が実装してあり、画面に入力のヒントや操作方法などが表示されます。
</details>
