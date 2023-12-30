export class Todo {
    constructor(
      public id?: number,
      public TitleTytul?: string,
      public CompletedUkonczone?: boolean,
    ){
      this.CompletedUkonczone = false;
    }
  }