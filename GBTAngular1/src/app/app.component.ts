import { Component } from '@angular/core';
import { TranslationService } from './shared/i18n';
import { locale as enLang } from './shared/i18n/vocabs/en';
import { locale as bsLang } from './shared/i18n/vocabs/bs';
import { locale as esLang } from './shared/i18n/vocabs/es';
import { locale as deLang } from './shared/i18n/vocabs/de';
import { locale as frLang } from './shared/i18n/vocabs/fr';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent { 
   title = 'nobleui-angular';

constructor(private translationService: TranslationService) {
  this.translationService.loadTranslations(
    bsLang,
    enLang,
    esLang,
    deLang,
    frLang
  );

}
}
