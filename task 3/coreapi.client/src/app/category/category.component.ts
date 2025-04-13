import { Component } from '@angular/core';
import { UrlService } from '../service/url.service';

@Component({
  selector: 'app-category',
  standalone: false,
  templateUrl: './category.component.html',
  styleUrl: './category.component.css'
})
export class CategoryComponent {
  constructor(private _url: UrlService) { }

  ngOnInit() {
    this.getAllCategory();
  }
  category: any
  getAllCategory() {
    return this._url.getCategory().subscribe((data) => {
      this.category = data

    })
  }
}
